using System;
using Core.Application.Contracts.Repositories;
using Core.Domain.Entities;
using Infrastructure.Persistence.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Persistence
{
    public static class PersistenceContainer
    {
        public static IServiceCollection AdPersistenceRegistration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Default"), opt =>
                    opt.EnableRetryOnFailure(5,
                        TimeSpan.FromSeconds(30),
                        null)));
            
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 7;
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;

            });
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}