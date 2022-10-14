using App.Plan;
using App.Procure;
using Microsoft.AspNetCore.Mvc;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcureController : Controller
    {
        protected readonly IProcureServices _Service;
        private readonly ILogger _Logger;

        public ProcureController(ILogger<ProcureController> logger, IProcureServices ProcureServices)
        {
            _Service = ProcureServices;

            _Logger = logger;

            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }
        [HttpGet]
        [Route("RequestForms/{year}")]
        public IActionResult PlanActivities(int year)
        {
            _Logger.LogInformation("sql");
            var data = _Service.getRequestFormbyYear(year);

            return Json(data);
        }
        [HttpGet]
        [Route("ApproveForms/{year}")]
        public IActionResult ApproveFormsByYear(int year)
        {
            _Logger.LogInformation("sql");
            var data = _Service.getApproveFormsbyYear(year);

            return Json(data);
        }
        [HttpGet]
        [Route("OrderForms/{year}")]
        public IActionResult OrderFormsByYear(int year)
        {
            _Logger.LogInformation("sql");
            var data = _Service.getOrderFormbyYear(year);

            return Json(data);
        }
        [HttpGet]
        [Route("CheckForms/{year}")]
        public IActionResult CheckFormsByYear(int year)
        {
            _Logger.LogInformation("sql");
            var data = _Service.getCheckFormbyYear(year);

            return Json(data);
        }
        [HttpGet]
        [Route("ProcureLoaningMemoForms/{year}")]
        public IActionResult ProcureLoaningMemoFormByYear(int year)
        {
            _Logger.LogInformation("sql");
            var data = _Service.getProcureLoaningMemoFormsbyYear(year);

            return Json(data);
        }
        

    }
}
