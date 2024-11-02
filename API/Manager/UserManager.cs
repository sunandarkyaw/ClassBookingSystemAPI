using BookingService.Manager.Interface;
using Core.Entities.Models;
using Core.Entities.InputModels;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Security.Cryptography;

namespace BookingService.Manager
{
    public class UserManager : IUserManager
    {
        public string GenerateJwtToken(LoginInfo info, string jwtkey, string jwtIssueer, string jwtAudience)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(jwtkey);
            var tokenDescriptior = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]{
                    new("userCode", info.userCode),
                    new("email",info.userCode + "@gmail.com")
                }),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptior);
            var refreshToken = GenerateRefreshToken();

            return tokenHandler.WriteToken(token);
        }


        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        public AuthorizeUserInfo GetUser(LoginInfo userInfo)
        {
            AuthorizeUserInfo user = new AuthorizeUserInfo();
            user.UserName = userInfo.userCode;
            user.UserCode = userInfo.userCode;
            user.Email = userInfo.userCode + "@gmail.com";
            return user;
        }

    }
}
