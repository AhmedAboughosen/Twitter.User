using System.Linq;
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
    public class ConfirmEmailHandler : IRequestHandler<ConfirmEmailRequestDto, bool>
    {
        private readonly UserManager<User> _userManager;
    
        public ConfirmEmailHandler(UserManager<User> userManager)
        {
            _userManager = userManager;
        }


        public async Task<bool> Handle(ConfirmEmailRequestDto dto,
            CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);


            if (user == null)
                throw new APIException(
                    "Invalid Account", HttpStatusCode.NotFound);


            var result = await _userManager.ConfirmEmailAsync(user, dto.Token);

            if (!result.Succeeded)
            {
                throw new APIException(
                    result.Errors.First().Description, HttpStatusCode.Forbidden);
            }

            return true;
        }
    }
}