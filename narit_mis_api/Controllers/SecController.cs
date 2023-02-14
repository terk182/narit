using App.SEC;
using App.SEC.Requests;
using Microsoft.AspNetCore.Mvc;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecController : Controller
    {
        protected readonly ISecServices _SecServices;
       
        private readonly ILogger _Logger;

        public SecController(ILogger<SecController> logger, ISecServices SecServices)
        {
            _SecServices = SecServices;
            _Logger = logger;

            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }

        //[HttpGet]
        //[Route("SEC/GetScheduleFisicalYear")]
        //public IActionResult GetScheduleFisicalYear()        {
        //    var data = _SecServices.GetScheduleFisicalYear();
        //    return Json(data);
        //}
        //[HttpGet]
        //[Route("SEC/GetScheduleFisicalYearByYears")]
        //public IActionResult GetScheduleFisicalYearByYears(int name, bool active)
        //{
        //    var data = _SecServices.GetScheduleFisicalYearByYears(name, active);
        //    return Json(data);
        //}
        [HttpGet]
        [Route("Form/GetRequestBudget")]
        public IActionResult GetRequestBudget()
        {
            var data = _SecServices.GetRequestBudget();
            return Json(data);
        }
        [HttpGet]
        [Route("Form/GetRequestBudgetByDocNo/{docNo}")]
        public IActionResult GetRequestBudgetByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestBudgetByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("Form/CreateRequestBudget")]
        public IActionResult CreateRequestBudget(RequestBudgetRequests request)
        {
            var data = _SecServices.CreateRequestBudget(request);
            return Json(data);
        }
        //[HttpPut]
        //[Route("Form/EditRequestBudgetById")]
        //public IActionResult EditRequestBudgetById(RequestBudgetRequests request)
        //{
        //    var data = _SecServices.EditRequestBudgetById(request);
        //    return Json(data);
        //}
        [HttpDelete]
        [Route("Form/DeleteRequestBudgetByDocNo/{docNo}")]
        public IActionResult DeleteRequestBudgetByDocNo(string docNo)
        {
            var data = _SecServices.DeleteRequestBudgetByDocNo(docNo);
            return Json(data);
        }

        //[HttpGet]
        //[Route("Form/GetRequestForm")]
        //public IActionResult GetRequestForm()
        //{
        //    var data = _SecServices.GetRequestForm();
        //    return Json(data);
        //}
        [HttpGet]
        [Route("Form/GetRequestFormByDocNo/{docNo}")]
        public IActionResult GetRequestFormByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestFormByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("Form/CreateRequestFormByDocNo")]
        public IActionResult CreateRequestFormByDocNo(RequestFormRequests request)
        {
            var data = _SecServices.CreateRequestFormByDocNo(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("Form/DeleteRequestFormById/{id}")]
        public IActionResult DeleteRequestFormById(int id)
        {
            var data = _SecServices.DeleteRequestFormById(id);
            return Json(data);
        }
        [HttpGet]
        [Route("Form/GetRequestFormItemsByDocNo/{docNo}")]
        public IActionResult GetRequestFormItemsByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestFormItemsByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("Form/CreateRequestFormItemsByDocNo")]
        public IActionResult CreateRequestFormItemsByDocNo(RequestFormItemsRequests request)
        {
            var data = _SecServices.CreateRequestFormItemsByDocNo(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("Form/DeleteRequestFormItemsById/{id}")]
        public IActionResult DeleteRequestFormItemsById(int id)
        {
            var data = _SecServices.DeleteRequestFormItemsById(id);
            return Json(data);
        }
        [HttpGet]
        [Route("Form/GetRequestFormApproveByDocNo/{docNo}")]
        public IActionResult GetRequestFormApproveByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestFormApproveByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("Form/CreateRequestFormApproveByDocNo")]
        public IActionResult CreateRequestFormApproveByDocNo(RequestFormApproveRequests request)
        {
            var data = _SecServices.CreateRequestFormApproveByDocNo(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("Form/DeleteRequestFormApproveById/{id}")]
        public IActionResult DeleteRequestFormApproveById(int id)
        {
            var data = _SecServices.DeleteRequestFormApproveById(id);
            return Json(data);
        }

        [HttpGet]
        [Route("Form/GetRequestFormCommentByDocNo/{docNo}")]
        public IActionResult GetRequestFormCommentByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestFormCommentByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("Form/CreateRequestFormCommentByDocNo")]
        public IActionResult CreateRequestFormCommentByDocNo(RequestFormCommentRequests request)
        {
            var data = _SecServices.CreateRequestFormCommentByDocNo(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("Form/DeleteRequestFormCommentById/{id}")]
        public IActionResult DeleteRequestFormCommentById(int id)
        {
            var data = _SecServices.DeleteRequestFormCommentById(id);
            return Json(data);
        }

        [HttpGet]
        [Route("Form/GetRequestFormBorrowingMoneyByDocNo/{docNo}")]
        public IActionResult GetRequestFormBorrowingMoneyByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestFormBorrowingMoneyByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("Form/CreateRequestFormBorrowingMoneyByDocNo")]
        public IActionResult CreateRequestFormBorrowingMoneyByDocNo(RequestFormBorrowingMoneyRequests request)
        {
            var data = _SecServices.CreateRequestFormBorrowingMoneyByDocNo(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("Form/DeleteRequestFormBorrowingMoneyById/{id}")]
        public IActionResult DeleteRequestFormBorrowingMoneyById(int id)
        {
            var data = _SecServices.DeleteRequestFormBorrowingMoneyById(id);
            return Json(data);
        }

        [HttpGet]
        [Route("Form/GetRequestFormScheduleByDocNo/{docNo}")]
        public IActionResult GetRequestFormScheduleByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestFormScheduleByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("Form/CreateRequestFormScheduleByDocNo")]
        public IActionResult CreateRequestFormScheduleByDocNo(RequestFormScheduleRequests request)
        {
            var data = _SecServices.CreateRequestFormScheduleByDocNo(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("Form/DeleteRequestFormScheduleById/{id}")]
        public IActionResult DeleteRequestFormScheduleById(int id)
        {
            var data = _SecServices.DeleteRequestFormScheduleById(id);
            return Json(data);
        }

        [HttpGet]
        [Route("Form/GetRequestFormExaminerForBudgetByDocNo/{docNo}")]
        public IActionResult GetRequestFormExaminerForBudgetByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestFormExaminerForBudgetByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("Form/CreateRequestFormExaminerForBudgetByDocNo")]
        public IActionResult CreateRequestFormExaminerForBudgetByDocNo(RequestFormExaminerForBudgetRequests request)
        {
            var data = _SecServices.CreateRequestFormExaminerForBudgetByDocNo(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("Form/DeleteRequestFormExaminerForBudgetById/{id}")]
        public IActionResult DeleteRequestFormExaminerForBudgetById(int id)
        {
            var data = _SecServices.DeleteRequestFormExaminerForBudgetById(id);
            return Json(data);
        }
    }
}
