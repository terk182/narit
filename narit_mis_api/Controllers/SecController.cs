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

        //GetScheduleFisicalYear
        [HttpGet]
        [Route("SEC/GetScheduleFisicalYear")]
        public IActionResult GetScheduleFisicalYear()
        {
            var data = _SecServices.GetScheduleFisicalYear();
            return Json(data);
        }

        //GetScheduleFisicalYear
        [HttpGet]
        [Route("SEC/GetScheduleFisicalYearByYears")]
        public IActionResult GetScheduleFisicalYearByYears(string name, bool active)
        {
            var data = _SecServices.GetScheduleFisicalYearByYears(name, active);
            return Json(data);
        }
    }
}
