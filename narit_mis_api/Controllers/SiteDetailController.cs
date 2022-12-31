using App.Accommodations;
using App.PathDetail;
using App.PathDetail.Requests;
using Microsoft.AspNetCore.Mvc;
using narit_mis_api.Controllers;

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
        [HttpPost]
        public IActionResult getbytitle(SiteRequest request)
        {
            var data = _Service.Sitemap("./json/sitemap.json");
            var result = data.Find(x => x.th_title == request.th_title);

            return Json(result);
        }
        [HttpGet]
        [Route("clss_list")]
        public IActionResult get_clss_list()
        {
            var data = _Service.get_db_class("./json/database_class_list.json");
          

            return Json(data);
        }
        [HttpGet]
        [Route("clss_list/{table}")]
        public IActionResult get_clss_list_by_table(string table)
        {
            var data = _Service.get_db_class("./json/database_class_list.json");
            var result = data.Where(x => x.table == table).ToList();

            return Json(result);

         
        }
    }
}
