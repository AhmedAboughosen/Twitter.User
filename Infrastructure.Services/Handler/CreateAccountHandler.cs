using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Core.Application.Contracts.Services;
using Core.Domain.Entities;
using Core.Domain.Enums;
using Core.Domain.Exceptions;
using Core.Domain.Model.DTO.RequestDTO;
using Core.Domain.Model.MessageBroker;
using Infrastructure.Services.Grpc.Protos.SendEmail;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Services.Handler
{
    public class CreateAccountHandler : IRequestHandler<UserRegistrationRequestDto, bool>
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfigurationSection _jwtSettings;
        private readonly IMessageProducer _messageProducer;
        private readonly LinkGenerator _linkGenerator;

        public CreateAccountHandler(UserManager<User> userManager, IConfigurationSection jwtSettings,
            LinkGenerator linkGenerator, IMessageProducer messageProducer)
        {
            _userManager = userManager;
            _jwtSettings = jwtSettings;
            _linkGenerator = linkGenerator;
            _messageProducer = messageProducer;
        }


        public async Task<bool> Handle(UserRegistrationRequestDto dto,
            CancellationToken cancellationToken)
        {
            var user = new User(dto);
            var result = await _userManager.CreateAsync(user, dto.Password);

            if (!result.Succeeded)
            {
                throw new APIException(
                    result.Errors.First().Description, HttpStatusCode.Forbidden);
            }

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var confirmationLink = _linkGenerator.GetPathByAction("", "", new {code, email = user.Email});

            // var confirmationLink = Url.Action(nameof(ConfirmEmail), "Account", new { code, email = user.Email });
            // // var message = new Message(new string[] { user.Email }, "Confirmation email link", confirmationLink, null);
            await _messageProducer.SendMessageAsync(new MessageBody<EmailMessageModel>
            {
                Data = new EmailMessageModel
                {
                    To = user.Email,
                    Subject = "confirmation email",
                    Content = confirmationLink
                },
                DateTime = DateTime.UtcNow
            });

            await _userManager.AddToRoleAsync(user, Roles.NormalUser.ToString());

            return true;
        }
    }
}