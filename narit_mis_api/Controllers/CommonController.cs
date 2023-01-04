using App.Common;

using App.SEC;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace narit_mis_api.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("api/[controller]")]
    public class CommonController : Controller
    {
    
        protected readonly ICommonServices _CommonServices;
        protected readonly ISecServices _SecServices;
        private readonly ILogger _Logger;

        public CommonController(ILogger<CommonController> logger, ICommonServices Service, ISecServices SecServices)
        {
            _CommonServices = Service;
            _Logger = logger;
            _SecServices = SecServices;

            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }
        [HttpGet]
        [Route("/Common/StrategyDetails/{year}/{id}")]
        public IActionResult StrategySetupByFiscalYearandStrategyId(int year, int id)
        {
            var data = _SecServices.StrategySetupByFiscalYearandStrategyId(year, id);
            return Json(data);
        }
        [HttpGet]
        [Route("/Common/PrinciplePlanTags")]
        public IActionResult EditPlanPrinciplePlanTags()
        {
            var data = _SecServices.EditPlanPrinciplePlanTags();
            return Json(data);
        }
        [HttpGet]
        [Route("/Common/StrategicIndicatorServ/{fiscalYear}")]
        public IActionResult EditStrategicIndicatorServ(int fiscalYear)
        {
            var data = _SecServices.EditPlanStrategicIndicatorServ(fiscalYear);
            return Json(data);
        }


        [HttpGet]
        [Route("/Common/PerformanceIndicator/{fiscalYear}")]
        public IActionResult EditPlanEditPerformanceIndicator(int fiscalYear)
        {
            var data = _SecServices.EditPerformanceIndicator(fiscalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/Common/Departments/{fiscalYear}")]
        public IActionResult EditPlanEditGetDepartments(int fiscalYear)
        {
            var data = _SecServices.GetDepartments(fiscalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/Common/DepartmentDetails/{year}/{id}")]
        public IActionResult SelectDepartmentGetByFiscalYearandDepartmentid(int year, int id)
        {
            var data = _SecServices.DepartmentGetByFiscalYearandDepartmentid(year, id);
            return Json(data);
        }

        [HttpGet]
        [Route("/Common/BudgetTypes/{fiscalYear}")]
        public IActionResult BudgetTypes(int fiscalYear)
        {
            var data = _CommonServices.GetBudgetTypes(fiscalYear);
            return Json(data);
        }

        [HttpGet]
        [Route("/Common/PlanType/{fiscalYear}")]
        public IActionResult GetPlanType(int fiscalYear)
        {
            var data = _CommonServices.GetPlanType(fiscalYear);
            return Json(data);
        }

        [HttpGet]
        [Route("/Common/PlanTypeDetails/{year}/{id}")]
        public IActionResult SelectViewPlanForActivityByPlanTypeGetByFiscalYearandPlanTypeid(int year, int id)
        {
            var data = _SecServices.PlanTypeGetByFiscalYearandPlanTypeid(year, id);
            return Json(data);
        }

    }
}
