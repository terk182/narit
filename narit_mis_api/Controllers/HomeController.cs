using App.EIS;
using App.PathDetail;
using App.Plan;
using Microsoft.AspNetCore.Mvc;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
     
        protected readonly IPlanServices _Service;
        private readonly ILogger _Logger;

        public HomeController(ILogger<HomeController> logger, IPlanServices Service)
        {
            _Service = Service;
        
            _Logger = logger;

            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }
        [HttpGet]
        [Route("GetWaitingForApprove/{staffId}/{yearNow}")]
        public IActionResult GetWaitingForApprove(int staffId, int yearNow)
        {
            var data = _Service.GetWaitingForApprove(staffId, yearNow);

            return Json(data);
        }
        
    }
}
