using Test.Models;
using Microsoft.AspNetCore.Mvc;
using Piranha;
using Piranha.AspNetCore.Services;
using System;
using System.Threading.Tasks;

namespace Test.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        private readonly IApi _api;
        private readonly IModelLoader _loader;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="api">The current api</param>
        public LoginController(IApi api, IModelLoader loader)
        {
            _api = api;
            _loader = loader;
        }

        
        public IActionResult Login(Guid id, bool draft = false)
        {
        //     var model = await _loader.GetPageAsync<StandardPage>(id, HttpContext.User, draft);

        //     return View(model);

            return View();
        }
    }
}
