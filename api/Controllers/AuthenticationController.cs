using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using api.Services;
using api.Models;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : Controller
    {
        [EnableCors]
        // GET: AuthController/Details/5
        [HttpPost("Authenticate")]
        public bool Authenticate([FromBody] User user)
        {
            AuthenticationService authenticationService = new AuthenticationService();
            return authenticationService.AuthenticateUser(user);
        }

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
