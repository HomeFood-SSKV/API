using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WebApi.Common.Helper
{
    public static class ConfigurationExtensions
    {
 

        public static string GetRedisConnection(this IConfiguration configuration)
        {
            string result = configuration.GetValue<string>("AppSetting:RedisConnection");
            return result;
        }

        public static string GetValidIssuer(this IConfiguration configuration)
        {
            string result = configuration.GetValue<string>("Authentication:JwtBearer:Issuer");
            return result;
        }

        public static string GetValidAudience(this IConfiguration configuration)
        {
            string result = configuration.GetValue<string>("Authentication:JwtBearer:Audience");
            return result;
        }

        public static string GetDefaultPolicy(this IConfiguration configuration)
        {
            string result = configuration.GetValue<string>("Policies:Default");
            return result;
        }

        //public static SymmetricSecurityKey GetSymmetricSecurityKey(this IConfiguration configuration)
        //{
        //    var issuerSigningKey = configuration.GetIssuerSigningKey();
        //    var data = Encoding.UTF8.GetBytes(issuerSigningKey);
        //    var result = new SymmetricSecurityKey(data);
        //    return result;
        //}

        public static string[] GetCorsOrigins(this IConfiguration configuration)
        {
            string[] result =
                configuration.GetValue<string>("App:CorsOrigins")
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            return result;
        }
    }
}
