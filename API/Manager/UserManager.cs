using BookingService.Manager.Interface;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BookingService.Manager
{
    public class UserManager : IUserManager
    {
        public string GenerateJwtToken(string userName)
        {
            // Define the token expiration time
            var expiryDuration = TimeSpan.FromMinutes(30);

            var claims = new[]
            {
        new Claim(JwtRegisteredClaimNames.Sub, userName),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    };

            // Configure the key, issuer, and audience
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ThisIsASecureKeyForJwtAuthentication123!")); // Ensure the key is at least 16 bytes
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "yourIssuer", // Change to your issuer
                audience: "yourAudience", // Change to your audience
                claims: claims,
                expires: DateTime.Now.Add(expiryDuration),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
