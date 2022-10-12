using App.Accommodations;
using App.PathDetail;
using Microsoft.AspNetCore.Mvc;
using Narit_API.Controllers;

namespace narit_mis_api.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class SiteDetailController : Controller
    {
        protected readonly IPathDetailService _Service;
        private readonly ILogger _Logger;

        public SiteDetailController(ILogger<SiteDetailController> logger, IPathDetailService Service)
        {
            _Service = Service;
            _Logger = logger;
            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }
        [HttpGet]
       
        public IActionResult getAll()
        {
            _Logger.LogInformation("test Logger");
            var data = _Service.Sitemap("./json/sitemap.json");

            return Json(data);
        }
    }
}
