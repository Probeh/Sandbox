using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Library.Extensions
{
    public static partial class Extensions
    {
        public static void CreateToken(this HttpResponse response, IConfiguration config)
        {
            var security = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetSection("SecurityKey").Value));
            var credential = new SigningCredentials(security, SecurityAlgorithms.HmacSha512Signature);
            var descriptor = new SecurityTokenDescriptor()
            {
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = credential
            };
            var handler = new JwtSecurityTokenHandler();
            var token = handler.CreateToken(descriptor);

            response.Headers.Add("Authorization", handler.WriteToken(token));
        }
    }
}
