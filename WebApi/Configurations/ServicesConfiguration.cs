﻿
using Microsoft.Extensions.DependencyInjection;
using DotnetCore.Business;
using DotnetCore.Business.Interfaces;
using Newtonsoft.Json;
using WebApi.Common.JwtParser;

namespace Chinook.API.Configurations
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection ConfigureRepositories(this IServiceCollection services) =>
            services.AddScoped<IBusiness, DotnetCoreSvr>().
         AddScoped<JwtService>();

        public static IServiceCollection AddMiddleware(this IServiceCollection services)
        {
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
            return services;
        }

        public static IServiceCollection AddCorsConfiguration(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", new Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder()
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin()
                .AllowCredentials()
                .Build());
            });

    }
}