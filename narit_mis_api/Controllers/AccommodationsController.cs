using App.Accommodations;
using App.Accommodations.Model.Requests;

using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using narit_mis_api.Models;

namespace narit_mis_api.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class AccommodationsController : Controller
    {
        protected readonly IAccommodationsService _Service;
        private readonly ILogger _Logger;

        public AccommodationsController(ILogger<AccommodationsController> logger, IAccommodationsService Service)
        {
            _Service = Service;
            _Logger = logger;
            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult getAll()
        {
            _Logger.LogInformation("test Logger");
            var data = _Service.getAll();

            return Json(data);
        }

        [HttpGet]
        [Route("GetById/{Id}")]
        public IActionResult getAll(int Id)
        {

            var data = _Service.getById(Id);

            return Json(data);
        }
        [HttpPost]
        [Route("ReadByName")]
        public IActionResult ReadByName(AccommodationsRequest Request)
        {

            var data = _Service.PostReadByName(Request);

            return Json(data);
        }
        [HttpPost]
        [Route("create")]
        public IActionResult create(Accommodation Request)
        {

            var data = _Service.Add(Request);

            return Json(data);
        }

        [HttpPut]

        public IActionResult updateAccommodations(Accommodation Request)
        {
            _Logger.LogInformation("test Logger");
            var data = _Service.update(Request);

            return Json(data);
        }

        [HttpDelete]
        [Route("{Id}")]
        public IActionResult DeleteAccommodations(int Id)
        {

            var data = _Service.delete(Id);

            return Json(data);
        }
    }
}
