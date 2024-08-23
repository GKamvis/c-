using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Webapi_student_questionnaire.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        string siginKey = "ThisIsMySignigKeyqwertyuiopasdfghjklsdfsdfsdfsdfsdfsdfsd";
        [HttpGet]
        public string GetAuth(string username , string password)
        {

            var Claims = new[]{
                new Claim(ClaimTypes.Name , username),
                new Claim(ClaimTypes.Email , username)
        };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(siginKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer:"https://www.parfumex.az",
                audience:"thisismyaudience",
                claims : Claims,
                expires: DateTime.Now.AddDays(11),
                notBefore:DateTime.Now,
                signingCredentials:credentials
                );
             var token  = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            return token;
        }
        [HttpGet("ValidateToken")]
        public bool Validatetoken(string token)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(siginKey));
            try
            {
                JwtSecurityTokenHandler handler = new();
                handler.ValidateToken(token, new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = securityKey,
                    ValidateLifetime = true,
                    ValidateAudience = false,
                    ValidateIssuer = false
                   
                }, out SecurityToken validatedToken) ;

                var jwtToken = (JwtSecurityToken)validatedToken;
                var claims = jwtToken.Claims.ToList();
                return true;


            }
            catch (System.Exception )
            {
                return false;
            }
        }

    }
}
