
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using WebApi.Common.Helper;

namespace WebApi.Common.JwtParser
{

    //public interface IJwtService
    //{
    //    Task<JwtClaim> Authenticate(string JwtClaimname, string password);
    //    IEnumerable<JwtClaim> GetAll();
    //}

    public class JwtService : BaseModel //, IJwtService
    {
        // JwtClaims hardcoded for simplicity, store in a db with hashed passwords in production applications
        private List<JwtClaim> _JwtClaims = new List<JwtClaim>();

        private readonly AppSettings _appSettings;

        public JwtService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public async Task<JwtClaim> Authenticate(string userName, string password)
        {
            var loginList = await businessSupervisor.GetTRNUserPassword();
            var userList = await businessSupervisor.GetTRNUserDetail();
            var login = loginList.SingleOrDefault(x => x.LoginName == userName && x.Password == password);
            
            // return null if JwtClaim not found
            if (login == null)
                return null;
            var user = userList.SingleOrDefault(x => x.UserId == login.UserId);

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, login.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            var jwtClaim = new JwtClaim
            {
                Id = user.UserId,
                FirstName = user.Name,
                LastName = user.Name,
                Username = login.LoginName,
                Token = tokenHandler.WriteToken(token)
            };

            return jwtClaim;
        }

        public IEnumerable<JwtClaim> GetAll()
        {
            // return JwtClaims without passwords
            return _JwtClaims.Select(x =>
            {
                return x;
            });
        }
    }
}

