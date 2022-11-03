﻿using App.Common;
using App.EIS;
using App.PathDetail;
using App.SEC;
using Microsoft.AspNetCore.Mvc;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommonController : Controller
    {
    
        protected readonly ICommonServices _Service;
        protected readonly ISecServices _SecServices;
        private readonly ILogger _Logger;

        public CommonController(ILogger<CommonController> logger, ICommonServices Service, ISecServices SecServices)
        {
            _Service = Service;
            _Logger = logger;
            _SecServices = SecServices;

            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
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
        [Route("/Common/EditPlan/PlanTypeTree/{fiscalYear}")]
        public IActionResult EditPlanTypeTree(int fiscalYear)
        {
            var data = _SecServices.EditPlanStrategicIndicatorServ(fiscalYear);
            return Json(data);
        }


        [HttpGet]
        [Route("/Common/EditPlan/EditPerformanceIndicator/{fiscalYear}")]
        public IActionResult EditPlanEditPerformanceIndicator(int fiscalYear)
        {
            var data = _SecServices.EditPerformanceIndicator(fiscalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/Common/GetDepartments/{fiscalYear}")]
        public IActionResult EditPlanEditGetDepartments(int fiscalYear)
        {
            var data = _SecServices.GetDepartments(fiscalYear);
            return Json(data);
        }

    }
}