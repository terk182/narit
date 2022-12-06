﻿
using App.Authenticator;
using App.Authenticator.Models.Requests;
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
        [Route("/LogIn")]
        public IActionResult LogIn([FromBody]AuthenticatorRequest request)
        {
            var data = _AuthenticatorServices.LogInCheck(request);
            return Json(data);
        }

        [HttpGet]
        [Route("/ManageUser/getAllUser")]
        public IActionResult getAllUser()
        {
            var data = _AuthenticatorServices.getAllUser();
            return Json(data);
        }


    }
}
