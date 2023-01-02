using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Core.Domain.Entities;
using Core.Domain.Exceptions;
using Core.Domain.Model.DTO.RequestDTO;
using Infrastructure.Services.Grpc.Protos.SendEmail;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Services.Handler
{
    public class UpdateProfileHandler : IRequestHandler<UpdateProfileRequestDto, bool>
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfigurationSection _jwtSettings;
        private readonly EmailSender.EmailSenderClient _emailSenderClient;
        private readonly LinkGenerator _linkGenerator;

        public UpdateProfileHandler(UserManager<User> userManager, IConfigurationSection jwtSettings,
            EmailSender.EmailSenderClient emailSenderClient, LinkGenerator linkGenerator)
        {
            _userManager = userManager;
            _jwtSettings = jwtSettings;
            _emailSenderClient = emailSenderClient;
            _linkGenerator = linkGenerator;
        }


        public async Task<bool> Handle(UpdateProfileRequestDto dto,
            CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(dto.UserId);


            if (user == null)
            {
                throw new APIException(
                    "Invalid Account", HttpStatusCode.NotFound);
            }

            user.UpdateProfile(dto);

            await _userManager.UpdateAsync(user);
            return true;
        }
    }
}