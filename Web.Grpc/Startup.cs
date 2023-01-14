﻿using System;
using Infrastructure.MessageBus;
using Infrastructure.Persistence;
using Infrastructure.Services;
using Infrastructure.Services.Grpc.Protos.SendEmail;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Web.Grpc.ExceptionHandler;
using Web.Grpc.Interceptors;
using Web.Grpc.Services;

namespace Web.Grpc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc(o =>
            {
                {
                    o.Interceptors.Add<ThreadCultureInterceptor>();
                    o.Interceptors.Add<ExceptionHandlingInterceptor>();
                }
            });

            services.AddMessageBusRegistration(Configuration);
            services.AddPersistenceRegistration(Configuration);
            services.AddServicesRegistration(Configuration);


            services.AddGrpcClient<EmailSender.EmailSenderClient>((o) =>
            {
                o.Address = new Uri(Configuration["ClientUrls:EmailSenderClient"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<UserService>();
                endpoints.MapGrpcService<UserBuilderService>();

                endpoints.MapGet("/",
                    async context =>
                    {
                        await context.Response.WriteAsync(
                            "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                    });
            });
        }
    }
}