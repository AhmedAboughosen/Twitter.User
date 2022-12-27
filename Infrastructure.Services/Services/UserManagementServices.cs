using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Core.Domain.Entities;
using Core.Domain.Enums;
using Core.Domain.Exceptions;
using Core.Domain.Model.DTO.RequestDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Services.Services
{
    public class UserManagementServices : ServicesBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfigurationSection _jwtSettings;

        public UserManagementServices(UserManager<User> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _jwtSettings = configuration.GetSection("JwtSettings");
        }


        public async Task Register(UserRegistrationRequestDto dto)
        {
            var user = new User(dto);
            var result = await _userManager.CreateAsync(user, dto.Password);
            if (!result.Succeeded)
            {
                throw new APIException(
                    result.Errors.First().Description, HttpStatusCode.Forbidden);
            }

            // var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            // // var confirmationLink = Url.Action(nameof(ConfirmEmail), "Account", new { token, email = user.Email }, Request.Scheme);
            // // var message = new Message(new string[] { user.Email }, "Confirmation email link", confirmationLink, null);
            // // await _emailSender.SendEmailAsync(message);
            //

            await _userManager.AddToRoleAsync(user, Roles.NormalUser.ToString());
        }


        public async Task UpdateProfile(UpdateProfileRequestDto dto, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);


            if (user == null)
            {
                throw new APIException(
                    "Invalid Account", HttpStatusCode.NotFound);
            }

            user.UpdateProfile(dto);

            await _userManager.UpdateAsync(user);
        }
    }
}