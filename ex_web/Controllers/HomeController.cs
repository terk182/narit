using App.PathDetail;
using App.PathDetail.Models;
using ex_web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using static App.PathDetail.Models.d3_model;

namespace ex_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected readonly IPathDetailService _Service;
        protected readonly List<db_list> _db_class;
        protected readonly List<backlist> _backlist;
        string table_c;
        public HomeController(ILogger<HomeController> logger, IPathDetailService Service)
        {
            _Service = Service;
            _logger = logger;
            table_c = "";
            //_db_class = _Service.get_db_class("./json/database_class_list.json");
            //_backlist = _Service.get_backlist("./json/backlist.json");
        }
    }
}