// using Microsoft.EntityFrameworkCore;
// using System.Collections.Generic;
// using System.Linq;
// using ParkAPI.Models;
// using System.Security.Claims;
// using Microsoft.AspNetCore.Authentication.JwtBearer;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.Extensions.Configuration;
// using Microsoft.AspNetCore.Mvc;
// using System.IdentityModel.Tokens.Jwt;
// using Microsoft.IdentityModel.Tokens;
// using System;
// using System.Text;

// namespace ParkAPI.Controllers
// {

//     [Route("api/[controller]")]
//     [ApiController]
//     public class SecurityController : ControllerBase
//     {

//         private string GenerateJWT()
//         {
//             var issuer = _config["Jwt:Issuer"];
//             var audience = _config["Jwt:Audience"];
//             var expiry = DateTime.Now.AddMinutes(120);
//             var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
//             var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

//             var token = new JwtSecurityToken(issuer: issuer,
//                 audience: audience,
//                 expires: DateTime.Now.AddMinutes(120),
//                 signingCredentials: credentials);

//             var tokenHandler = new JwtSecurityTokenHandler();
//             var stringToken = tokenHandler.WriteToken(token);
//         }

//         private bool ValidateUser(User loginDetails)
//         {
//             if (loginDetails.UserName == "User1" && loginDetails.Password=="pass$word")
//             {
//                 return true;
//             }
//             else
//             {
//                 return false;
//             }
//         }

//         public class User
//         {
//             public string UserName { get; set; }
//             public string Password { get; set; }
//         }

//         [HttpPost]
//         public IActionResult Login([FromBody]User loginDetails)
//         {
//             bool result = ValidateUser(loginDetails);
//             if (result)
//             {
//             var tokenString = GenerateJWT();
//             return Ok(new { token = tokenString });
//             }
//             else
//             {
//                 return Unauthorized();
//             }
//         }
//     }
// }