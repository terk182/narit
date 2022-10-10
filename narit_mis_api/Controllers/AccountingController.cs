using App.Accounting;
using App.Accounting.Models;
using App.ExampleTest;
using App.ExampleTest.Models;
using Microsoft.AspNetCore.Mvc;
using narit_mis_api.Controllers;

namespace Narit_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountingController : Controller
    {
        protected readonly IService _Service;
        private readonly IConfiguration _configuration;
        private readonly ILogger _Logger;
        private readonly string connecttion;
        public AccountingController(ILogger<ExampleTestController> logger, IService ServiceExampleTest)
        {
            _Service = ServiceExampleTest;
            _Logger = logger;
            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }
        [HttpPost]
        [Route("PostTest")]
        public IActionResult PostTest(Tesk rq)
        {

            var data = _Service.GetAll(rq);
            string test1 = "1";
            string test2 = "2";
            return Json(data);
        }
    }
}
