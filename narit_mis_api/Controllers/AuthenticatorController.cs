
using App.Authenticator;
using Microsoft.AspNetCore.Mvc;

namespace narit_mis_api.Controllers
{
    public class AuthenticatorController : Controller
    {
        protected readonly IAuthenticatorServices _AuthenticatorServices;
        
        private readonly ILogger _Logger;

        public AuthenticatorController(ILogger<CommonController> logger, IAuthenticatorServices Service)
        {
            _AuthenticatorServices = Service;
            _Logger = logger;
            

            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }

        [HttpPost]
        [Route("/LogIn/{username}/{password}")]
        public IActionResult LogIn(string username, string password)
        {
            var data = _AuthenticatorServices.LogIn(username, password);
            return Json(data);
        }

    }
}
