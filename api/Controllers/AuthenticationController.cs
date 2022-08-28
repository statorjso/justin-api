using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using api.Services;
using api.Models;
using api.Utilities;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : Controller
    {
        //public AuthenticationService _authenticationService;

        //public AuthenticationController(AuthenticationService authenticationService)
        //{
        //    _authenticationService = authenticationService;
        //}

        [EnableCors]
        // GET: AuthController/Details/5
        [HttpPost("Authenticate")]
        public bool Authenticate([FromBody] User user)
        {
            AuthenticationService authenticationService = new AuthenticationService();
            return authenticationService.AuthenticateUser(user);
            //return _authenticationService.AuthenticateUser(user);
        }

        //[EnableCors]
        //// GET: AuthController/Details/5
        //[HttpPost("Authenticate")]
        //public string Authenticate([FromBody] User user)
        //{
        //    if (_authenticationService.AuthenticateUser(user))
        //    {
        //        string token = TokenManager.GenerateToken(user.Username);
        //        return token;
        //    }
        //    else
        //        return "";
        //}

        //public async Task<IActionResult> Post(User user)
        //{
        //    if (_authenticationService.AuthenticateUser(user))
        //    {
        //        //create claims details based on the user information
        //        var claims = new[] {
        //            new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
        //            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //            new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
        //            new Claim("UserId", user.UserId.ToString()),
        //            new Claim("DisplayName", user.DisplayName),
        //            new Claim("UserName", user.UserName),
        //            new Claim("Email", user.Email)
        //        };

        //        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        //        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        //        var token = new JwtSecurityToken(
        //            _configuration["Jwt:Issuer"],
        //            _configuration["Jwt:Audience"],
        //            claims,
        //            expires: DateTime.UtcNow.AddMinutes(10),
        //            signingCredentials: signIn);

        //        return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        //    }
        //    else
        //    {
        //        return BadRequest("Invalid credentials");
        //    }
        //}

        //[EnableCors]
        //// Post: AuthController/Details/5
        //[HttpPost("Authenticate")]
        //public bool Authenticate([FromBody] User user)
        //{
        //    AuthenticationService authenticationService = new AuthenticationService();
        //    return authenticationService.AuthenticateUser(user);
        //}

        // GET: AuthController/Details/5
        [HttpGet("Test")]
        public ActionResult Test()
        {
            return new JsonResult(true);
        }

        // GET: AuthController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AuthController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuthController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuthController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuthController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
