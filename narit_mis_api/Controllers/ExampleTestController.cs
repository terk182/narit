
using App.ExampleTest;
using App.ExampleTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExampleTestController : Controller
    {
        protected readonly IExampleTests _Service;
        private readonly IConfiguration _configuration;
        private readonly ILogger _Logger;
        private readonly string connecttion;
        public ExampleTestController(ILogger<ExampleTestController> logger, IExampleTests ServiceExampleTest)
        {
            _Service = ServiceExampleTest;
            _Logger = logger;
            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }
        [HttpPost]
        [Route("PostTest")]
        public IActionResult PostTest(ExData rq)
        {

            var data = _Service.testDi(rq.Id, rq.Name);
            return Json(data);
        }
        [HttpPost]
        [Route("Update")]
        public IActionResult PostTest1(ExData rq)
        {

            var data = _Service.testDi(rq.Id, rq.Name);
            return Json(data);
        }
    }
}
