using Microsoft.Extensions.Configuration;

namespace WebApi.Common
{
    public class AppSettings
    {
        public static string RedisConnection { get; set; }
        public static string Secret { get; set; }
        public static string ConnectionStrings { get; set; }


        public static void DefineAppSetting(IConfiguration Configuration)
        {
            RedisConnection = Configuration.GetValue<string>("AppSetting:RedisConnection");
            Secret = Configuration.GetValue<string>("AppSetting:Secret");
            ConnectionStrings = Configuration.GetValue<string>("ConnectionStrings:ChinookDb");


            //RedisConnection = Configuration.GetValue<string>("AppSetting:RedisConnection");
            //RedisConnection = Configuration.GetValue<string>("AppSetting:RedisConnection");
            //RedisConnection = Configuration.GetValue<string>("AppSetting:RedisConnection");
            //RedisConnection = Configuration.GetValue<string>("AppSetting:RedisConnection");
            //RedisConnection = Configuration.GetValue<string>("AppSetting:RedisConnection");
            //RedisConnection = Configuration.GetValue<string>("AppSetting:RedisConnection");
            //RedisConnection = Configuration.GetValue<string>("AppSetting:RedisConnection");
            //RedisConnection = Configuration.GetValue<string>("AppSetting:RedisConnection");
            //RedisConnection = Configuration.GetValue<string>("AppSetting:RedisConnection");
            //RedisConnection = Configuration.GetValue<string>("AppSetting:RedisConnection");
        }

    }
}
