using App.EIS;
using App.PathDetail;
using App.Plan;
using Microsoft.AspNetCore.Mvc;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanController : Controller
    {
        protected readonly IPlanServices _Service;
        private readonly ILogger _Logger;

        public PlanController(ILogger<PlanController> logger,  IPlanServices PlanServices)
        {
            _Service = PlanServices;
        
            _Logger = logger;

            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }
   



        [HttpGet]
        [Route("PlanActivities/{PlanCoreId}")]
        public IActionResult PlanActivities(int PlanCoreId)
        {
            var data = _Service.PlanActivityByPlanCoreId(PlanCoreId);

            return Json(data);
        }
        [HttpGet]
        [Route("PlanItems/{PlanActivityId}")]
        public IActionResult PlanItems(int PlanActivityId)
        {
            var data = _Service.PlanItemsByPlanActivityId(PlanActivityId);

            return Json(data);
        }
        //[HttpGet]
        //[Route("BudgetTransfers/{PlanItemId}")]
        //public IActionResult BudgetTransferByPlanItem(int PlanItemId)
        //{
        //    var data = _Service.BudgetTransferByPlanItemId(PlanItemId);

        //    return Json(data);
        //}
        //[HttpGet]
        //[Route("BudgetTransfers/{PlanCoreId}")]
        //public IActionResult BudgetTransferByPlanCore(int PlanCoreId)
        //{
        //    var data = _Service.BudgetTransferByPlanCoreId(PlanCoreId);

        //    return Json(data);
        //}
        [HttpGet]
        [Route("BudgetTransfers/{PlanActivityId}")]
        public IActionResult BudgetTransferPlanActivity(int PlanActivityId)
        {
            var data = _Service.BudgetTransferPlanActivityId(PlanActivityId);

            return Json(data);
        }

        [HttpGet]
        [Route("RequestFormPlanViews/{year}")]
        public IActionResult RequestFormPlanViewsByyear(int year)
        {
            var data = _Service.RequestFormPlanViewsByYear(year);

            return Json(data);
        }
        [HttpGet]
        [Route("CheckFormPlanViews/{year}")]
        public IActionResult CheckFormPlanViewsByyear(int year)
        {
            var data = _Service.CheckFormPlanViewByYear(year);

            return Json(data);
        }
        [HttpGet]
        [Route("CheckFormPlanViewsByRequestFormPlanViewId/{Id}")]
        public IActionResult CheckFormPlanViewByRequestFormPlanViewId(int Id)
        {
            var data = _Service.CheckFormPlanViewByRequestFormPlanViewId(Id);

            return Json(data);
        }

        [HttpGet]
        [Route("GetPlanItemByBudgetId/{Id}")]
        public IActionResult GetPlanItemByBudgetId(int Id)
        {
            var data = _Service.GetPlanItemByBudgetTypeId(Id);

            return Json(data);
        }

        
    }
}
