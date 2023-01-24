using App.PathDetail;
using App.Plan;
using App.SEC;
using Microsoft.AspNetCore.Mvc;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SetUpController : Controller
    {
        protected readonly IPathDetailService _Service;
        private readonly ILogger _Logger;
        public SetUpController(ILogger<SiteDetailController> logger, IPathDetailService Service)
        {
            _Service = Service;
            _Logger = logger;

            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }
    }
}
