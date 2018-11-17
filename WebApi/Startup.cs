﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Chinook.API.Configurations;
using Swashbuckle.AspNetCore.Swagger;
using DotnetCore.Business;
using DotnetCore.Web.Controllers;
using DotnetCore.Web.Models;
using Neeyamo.Web.Helpers;

namespace Chinook.API
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.ConfigureRepositories()
                .AddMiddleware()
                .AddCorsConfiguration()
                .AddConnectionProvider(Configuration)
                .AddAppSettings(Configuration);
            services.AddSession();
            //Add distributed cache service backed by Redis cache
            services.AddDistributedRedisCache(option =>
            {
                option.Configuration = Configuration.GetConnectionString("RedisConnection");
                option.InstanceName = "master";
            });

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Info {Title = "Chinook API", Description = "Chinook Music Store API"});
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            BusinessSupervisor.DotnetCoreSvr = new DotnetCoreSvr();
            BaseController.businessSupervisor =new BusinessSupervisor();
            RedisDbWrapper.DotnetCoreSvr = new DotnetCoreSvr();
            app.UseCors("AllowAll");

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "v1 docs");
            });
        }
    }
}