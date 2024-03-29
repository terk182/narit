﻿using App.PathDetail;
using App.PathDetail.Requests;
using App.Plan;
using App.Procure.Dtos;
using App.SEC;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using narit_mis_api.Models;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SetUpController : Controller
    {
        protected readonly IPathDetailService _Service;
        private readonly ILogger _Logger;
        public SetUpController(ILogger<SiteDetailController> logger, IPathDetailService Service)
        {
            _Service = Service;
            _Logger = logger;

            //_configuration = Configuration;
            // connecttion = _configuration.GetConnectionString("Defaultconnectton");
        }
        [HttpPost]
        [Route("SetMisSsoMatching")]
        public IActionResult SetMisSsoMatching(List<MisSsoMatching> req)
        {
            _Logger.LogInformation("sql");
            var data = _Service.SetMisSsoMatching(req);

            return Json(data);
        }
        [HttpPost]
        [Route("GetMisSsoMatching")]
        public IActionResult SetMisSsoMatching(MisSsoMatching req)
        {
            _Logger.LogInformation("sql");
            var data = _Service.GetMisSsoMatching(req);

            return Json(data);
        }
        [HttpPost]
        [Route("SetMisAccMatching")]
        public IActionResult SetMisAccMatching(List<MisAccMatching> req)
        {
            _Logger.LogInformation("sql");
            var data = _Service.SetMisAccMatching(req);

            return Json(data);
        }
        [HttpPost]
        [Route("GetMisAccMatching")]
        public IActionResult GetMisAccoMatching(MisAccMatching req)
        {
            _Logger.LogInformation("sql");
            var data = _Service.GetMisAccMatching(req);

            return Json(data);
        }
        [HttpPost]
        [Route("SetMisRegisterProcureItemTypesMatching")]
        public IActionResult SetMisRegisterProcureItemTypesMatching(List<MisProcureMatching> req)
        {
            _Logger.LogInformation("sql");
            var data = _Service.SetMisProcureItemMatching(req);

            return Json(data);
        }
        [HttpPost]
        [Route("GetMisRegisterProcureItemTypesMatching")]
        public IActionResult GetMisRegisterProcureItemTypesoMatching(MisProcureMatching req)
        {
            _Logger.LogInformation("sql");
            var data = _Service.GetMisProcureItemMatching(req);

            return Json(data);
        }
        [HttpPost]
        [Route("searchMisSsoMatching")]
        public IActionResult searchMisSsoMatching(MisUsers req)
        {
            _Logger.LogInformation("sql");
            var data = _Service.search(req);

            return Json(data);
        }
        [HttpPost]
        [Route("searchMisStaff")]
        public IActionResult searchStaff(MisUsers req)
        {
            _Logger.LogInformation("sql");
            var data = _Service.searchStaff(req);

            return Json(data);
        }
       //egisterProcureItemType


    }
}
