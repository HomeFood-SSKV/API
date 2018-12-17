using Microsoft.AspNetCore.Builder;
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
using WebApi.Common.Helper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebApi.Common;

namespace Chinook.API
{
    public class Startup
    {
        public static IConfiguration Configuration { get; set; }

        public IConfigurationRoot configurationRoot { get; set; }

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(env.ContentRootPath)
             .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

           // configuration = builder.Build();

            Configuration =  builder.Build(); 
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var redisconnection = Configuration.GetConnectionString("RedisConnection");
            var secret = Configuration.GetConnectionString("Secret");

            AppSettings.DefineAppSetting(Configuration);

            services.AddMvc();

            // Add our Config object so it can be injected
            services.Configure<AppSettings>(Configuration.GetSection("AppSetting"));


            //Add Jwt Token
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                  .AddJwtBearer(x =>
                  {
                      x.RequireHttpsMetadata = false;
                      x.SaveToken = true;
                      x.TokenValidationParameters = new TokenValidationParameters
                      {
                          ValidateIssuerSigningKey = true,
                          IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret)),
                          ValidateIssuer = false,
                          ValidateAudience = false
                      };
                  });

            //Add Session
            services.ConfigureRepositories()
                .AddMiddleware()
                .AddCorsConfiguration()
                .AddConnectionProvider(Configuration)
                .AddAppSettings(Configuration);

            //Add Session
            services.AddSession();

            //Add distributed cache service backed by Redis cache
            services.AddDistributedRedisCache(option =>
            {
                option.Configuration = redisconnection;
                option.InstanceName = "master";
            });

            //Add Session
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Info { Title = "Chinook API", Description = "Chinook Music Store API" });
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
            BaseController.businessSupervisor = new BusinessSupervisor();
            BaseModel.businessSupervisor = new BusinessSupervisor();
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