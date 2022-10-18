using App.Accommodations.Model.Requests;
using App.Accommodations;
using Microsoft.AspNetCore.Mvc;
using narit_mis_api.Models;
using App.EIS;
using App.PathDetail;
using App.PathDetail.Models;
using App.Plan;
using AutoMapper;
using App.Plan.Dtos;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EisController : Controller
    {

        protected readonly IPathDetailService _ServiceJson;
        protected readonly IEisServices _Service;
        protected readonly IPlanServices _PlanService;
        private readonly ILogger _Logger;
            
            public EisController(ILogger<EisController> logger, IEisServices Service, IPathDetailService PathDetailService, IPlanServices PlanService)
        {
            _Service = Service;
            _ServiceJson = PathDetailService;
            _PlanService = PlanService;
            _Logger = logger;

                //_configuration = Configuration;
                // connecttion = _configuration.GetConnectionString("Defaultconnectton");
            }
        #region Executive

      

 

        [HttpGet]
        [Route("Executive/pageload")]
        public IActionResult getExecutiveList()
        {
            //var dummy = new List<SiteMapNode>();
            //dummy.Add(new SiteMapNode
            //{
            //    th_title = ""
            //});
            var data = _ServiceJson.Sitemap("./json/sitemap.json");
            var main = data.Find(x => x.th_title == "ผู้บริหาร")!;
            var sub =  main.siteMapNode[0].siteMapNode;
            return Json(sub != null? sub:"error");
           
        }
       
        [HttpGet]
        [Route("Executive/Report/GovernmentDisbursementGoalReport/{year}")]
        public IActionResult GovernmentDisbursementGoalReport(int year)
        {
            var data = _Service.planCoreList(year);

            return Json(data);
        }

        [HttpGet]
        [Route("Executive/Report/PlanOperationFinancialResultDashboard/{year}")]
        public IActionResult PlanOperationFinancialResultDashboard(int year)
        {
            //var data = _Service.planCoreList(year);
            var data = _PlanService.GetByFiscalYear(year);
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<List<BudgetType>, List<BudgetTypeDto>>());
            //var mapper = new Mapper(config);

            //var BudgetType_cv = mapper.Map<List<BudgetType>>(data);
            var result = new List<BudgetTypeDto>();

            foreach (var item in data)
            {
                result.Add(new BudgetTypeDto
                {
                         Id = item.Id,
                        Name =item.Name,
                        Active = item.Active,
                        FiscalYear =item.FiscalYear,
                        ParentBudgetTypeId =item.ParentBudgetTypeId,
                        ReferenceOldId =item.ReferenceOldId,
                        ExpenseTypeEnum =item.ExpenseTypeEnum,
                        GovExpenseTypeEnum =item.GovExpenseTypeEnum,
    });
            }
            return Json(result);
        }

        #endregion


        [HttpGet]
            #region CollaborationNetwork
            
            [Route("CollaborationNetwork")]

            public IActionResult getAll()
            {
                _Logger.LogInformation("test Logger");
            var data = "test";

                return Json(data);
            }

            [HttpGet]
            [Route("CollaborationNetwork/Operate")]
            public IActionResult getAll(int Id)
            {

            var data = "test";

            return Json(data);
            }
            [HttpPost]
            [Route("CollaborationNetwork/Report")]
            public IActionResult ReadByName(AccommodationsRequest Request)
            {

            var data = "test";

            return Json(data);
            }
            [HttpPost]
            [Route("CollaborationNetwork/Setup")]
            public IActionResult created(AccommodationsRequest Request)
            {

            var data = "test";

            return Json(data);
            }

        //[HttpPut]

        //public IActionResult updateAccommodations(Accommodation Request)
        //{
        //    _Logger.LogInformation("test Logger");
        //var data = "test";

        //return Json(data);
        //}

        //[HttpDelete]
        //[Route("{Id}")]
        //public IActionResult DeleteAccommodations(int Id)
        //{

        //var data = "test";

        //return Json(data);
        //}

        #endregion

       

    }
}
