using App.EDU;
using App.GL.Requests;
using App.SEC;
using Microsoft.AspNetCore.Mvc;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MisEduController : Controller
    {
        protected readonly IEDUServices _EDUServices;

        private readonly ILogger _Logger;

        public MisEduController(ILogger<SecController> logger, IEDUServices EDUServices)
        {
            _EDUServices = EDUServices;
            _Logger = logger;

        }
        [HttpPost]
        [Route("EDU/LoginEdu")]
        public async Task<IActionResult> GetLoginEdus([FromBody] loginRequest request)
        {
            var data = await _EDUServices.LoginCgiEduApi(request);
            return new JsonResult(data);
        }
        [HttpGet]
        [Route("EDU/student/{q}")]
        public async Task<IActionResult> Getstudent(string q)
        {
            var data = await _EDUServices.student(q);
            return new JsonResult(data);
        }
    }
}
