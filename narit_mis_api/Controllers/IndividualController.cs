using Microsoft.AspNetCore.Mvc;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IndividualController : Controller
    {

        [HttpGet]
        [Route("EditPersonalInfo")]
        public IActionResult EditPersonalInfo()
        {
            return Json("EditPersonalInfo");
        }




    }
}
