using App.EIS.Models;
using App.PathDetail;
using App.Plan;
using App.Plan.Dtos;
using App.Procure;
using App.SEC;
using App.SEC.Dtos;
using App.SEC.enums;
using App.SEC.helper;
using App.SEC.Models;
using App.SEC.Models.Requests;
using App.SEC.Models.Responses;
using App.SEC.Requests;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecController : Controller
    {
        protected readonly IPlanServices _Service;
        protected readonly ISecServices _SecServices;
       
        private readonly ILogger _Logger;

        public SecController(ILogger<SecController> logger, IPlanServices PlanServices, ISecServices SecServices)
        {
            _Service = PlanServices;
            _SecServices = SecServices;

            _Logger = logger;

            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }

        [HttpGet]
        [Route("SEC/GetScheduleFisicalYear")]
        public IActionResult GetScheduleFisicalYear()
        {
            var data = _SecServices.GetScheduleFisicalYear();
            return Json(data);
        }
        [HttpGet]
        [Route("SEC/GetScheduleFisicalYearByYears")]
        public IActionResult GetScheduleFisicalYearByYears(int name, bool active)
        {
            var data = _SecServices.GetScheduleFisicalYearByYears(name, active);
            return Json(data);
        }
        
        [HttpGet]
        [Route("From/GetRequestBudget")]
        public IActionResult GetRequestBudget()
        {
            var data = _SecServices.GetRequestBudget();
            return Json(data);
        }
        [HttpGet]
        [Route("From/GetRequestBudgetById{id}")]
        public IActionResult GetRequestBudgetById(int id)
        {
            var data = _SecServices.GetRequestBudgetById(id);
            return Json(data);
        }
        [HttpPost]
        [Route("From/CreateRequestBudget")]
        public IActionResult CreateRequestBudget(RequestBudgetRequests request)
        {
            var data = _SecServices.CreateRequestBudget(request);
            return Json(data);
        }
        [HttpPut]
        [Route("From/EditRequestBudgetById")]
        public IActionResult EditRequestBudgetById(RequestBudgetRequests request)
        {
            var data = _SecServices.EditRequestBudgetById(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("From/DeleteRequestBudgetById{id}")]
        public IActionResult DeleteRequestBudgetById(int id)
        {
            var data = _SecServices.DeleteRequestBudgetById(id);
            return Json(data);
        }

        [HttpGet]
        [Route("From/GetRequestFrom")]
        public IActionResult GetRequestFrom()
        {
            var data = _SecServices.GetRequestFrom();
            return Json(data);
        }
        [HttpGet]
        [Route("From/GetRequestFromByDocNo/{docNo}")]
        public IActionResult GetRequestFromByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestFromByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("From/CreateRequestFrom")]
        public IActionResult CreateRequestFrom(RequestFormRequests? request)
        {
            var data = _SecServices.CreateRequestFrom(request);
            return Json(data);
        }

        [HttpGet]
        [Route("From/GetRequestFromItemsByDocNo")]
        public IActionResult GetRequestFromItemsByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestFromItemsByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("From/CreateRequestFromItemsByDocNo")]
        public IActionResult CreateRequestFromItemsByDocNo(RequestFormItemsRequests request)
        {
            var data = _SecServices.CreateRequestFromItemsByDocNo(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("From/DeleteRequestFromItemsByDocNo/{docNo}")]
        public IActionResult DeleteRequestFromItemsById(string docNo)
        {
            var data = _SecServices.DeleteRequestFromItemsById(docNo);
            return Json(data);
        }


        [HttpGet]
        [Route("From/GetRequestFormApproveByDocNo/{docNo}")]
        public IActionResult GetRequestFormApproveByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestFormApproveByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("From/CreateRequestFromApproveByDocNo")]
        public IActionResult CreateRequestFormApproveByDocNo(RequestFormApproveRequest request)
        {
            var data = _SecServices.CreateRequestFormApproveByDocNo(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("From/DeleteRequestFormApproveByDocNo/{docNo}")]
        public IActionResult DeleteRequestFormApproveByDocNo(string docNo)
        {
            var data = _SecServices.DeleteRequestFormApproveByDocNo(docNo);
            return Json(data);
        }

        [HttpGet]
        [Route("From/GetRequestCommentByDocNo/{docNo}")]
        public IActionResult GetRequestCommentByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestCommentByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("From/CreateRequestFromCommentByDocNo")]
        public IActionResult CreateRequestFromCommentByDocNo(RequestFormCommentRequests request)
        {
            var data = _SecServices.CreateRequestFromCommentByDocNo(request);
            return Json(data);
        }

        [HttpGet]
        [Route("From/GetRequestFormBorrowingMoneyByDocNo/{docNo}")]
        public IActionResult GetRequestFormBorrowingMoneyByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestFormBorrowingMoneyByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("From/CreateRequestFormBorrowingMoneyByDocNo")]
        public IActionResult CreateRequestFormBorrowingMoneyByDocNo(RequestFormBorrowingMoneyRequest request)
        {
            var data = _SecServices.CreateRequestFormBorrowingMoneyByDocNo(request);
            return Json(data);
        }

        [HttpGet]
        [Route("From/GetRequestFormScheduleByDocNo/{docNo}")]
        public IActionResult GetRequestFormScheduleByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestFormScheduleByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("From/CreateRequestFormScheduleByDocNo")]
        public IActionResult CreateRequestFormScheduleByDocNo(RequestFormScheduleRequests request)
        {
            var data = _SecServices.CreateRequestFormScheduleByDocNo(request);
            return Json(data);
        }

        [HttpGet]
        [Route("From/GetRequestFormExaminerForBudgetByDocNo/{docNo}")]
        public IActionResult GetRequestFormExaminerForBudgetByDocNo(string docNo)
        {
            var data = _SecServices.GetRequestFormExaminerForBudgetByDocNo(docNo);
            return Json(data);
        }
        [HttpPost]
        [Route("From/CreateRequestFormExaminerForBudgetByDocNo")]
        public IActionResult CreateRequestFormExaminerForBudgetByDocNo(RequestFormExaminerForBudgetRequests request)
        {
            var data = _SecServices.CreateRequestFormExaminerForBudgetByDocNo(request);
            return Json(data);
        }
    }
}
