//using System;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.IdentityModel.Tokens;

//namespace WebApiJwtExample
//{
//    [Route("/token")]
//    public class TokenController : Controller
//    {        
//        [HttpPost]
//        public IActionResult Create(string username, string password)
//        {
//            if (IsValidUserAndPasswordCombination(username, password))
//                return new ObjectResult(GenerateToken(username));
//            return BadRequest();
//        }

//        private bool IsValidUserAndPasswordCombination(string username, string password)
//        {
//            return !string.IsNullOrEmpty(username) && username == password;
//        }

//        private string GenerateToken(string username)
//        {
//            var claims = new Claim[]
//            {
//                new Claim(ClaimTypes.Name, username),new Claim(ClaimTypes.Country, "India"), 
//                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
//                new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddSeconds(15)).ToUnixTimeSeconds().ToString()),
//            };
//            //var time = TimeSpan.FromHours(5);
//            //var jwt = new JwtSecurityToken(
//            //    expires: DateTime.UtcNow.Add(time),
//            //    claims: claims);
//            //return new JwtSecurityTokenHandler().WriteToken(jwt);

//            var token = new JwtSecurityToken(
//                new JwtHeader(new SigningCredentials(
//                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes("the secret that needs to be at least 16 characeters long for HmacSha256")),
//                                             SecurityAlgorithms.HmacSha256)),
//                new JwtPayload(claims));

//            return new JwtSecurityTokenHandler().WriteToken(token);
//        }
//    }
//}