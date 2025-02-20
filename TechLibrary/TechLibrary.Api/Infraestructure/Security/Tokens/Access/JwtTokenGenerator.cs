using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TechLibrary.Api.Domain.Entities;

namespace TechLibrary.Api.Infraestructure.Security.Tokens.Access
{
    public class JwtTokenGenerator
    {
        public string Generate(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.Id.ToString())
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(SecurityKey(), SecurityAlgorithms.HmacSha256Signature),
                Subject = new ClaimsIdentity(claims)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(securityToken);
        }

        public SymmetricSecurityKey SecurityKey()
        {
            var signingKey = "re2FZvXGJzKmCX24srNkA4ZoMLygcvyb";
            var symetricKey = Encoding.UTF8.GetBytes(signingKey);

            return new SymmetricSecurityKey(symetricKey);
        }
    }
}
