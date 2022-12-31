using App.PathDetail;
using ex_web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ex_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected readonly IPathDetailService _Service;
        public HomeController(ILogger<HomeController> logger, IPathDetailService Service)
        {
            _Service = Service;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var data = _Service.get_db_class("./json/database_class_list.json");
            ViewBag.db = data;
            return View();
        }
        public IActionResult relation(string table)
        {

            var sub_table = table;
            var data = _Service.get_db_class("./json/database_class_list.json");
            var get_backlist = _Service.get_backlist("./json/backlist.json");
            bool check = false;
            foreach (var backlist in get_backlist)
            {
                if(table == backlist.name)
                {
                    ViewBag.db = data.Where(x => x.table == backlist.target).ToList();
                    check = true;
                    break;

                }
              
                
            }
            
           if(check == false)
            {
                var result = data.Where(x => x.table == table).ToList();
                if (result.Count == 0)
                {
                    table = table.Substring(0, table.Length - 1);
                    var result1 = data.Where(x => x.table == table).ToList();

                    if (result1.Count == 0)
                    {
                        table = table.Substring(0, table.Length - 1);
                        var result2 = data.Where(x => x.table == table).ToList();
                        if (result2.Count == 0)
                        {
                            table = String.Format("Aspnet{0}", sub_table);
                            var result3 = data.Where(x => x.table == table).ToList();
                            if (result3.Count == 0)
                            {
                                table = sub_table.Substring(0, sub_table.Length - 5);
                                ViewBag.db = data.Where(x => x.table == table).ToList();
                            }
                            else
                            {
                                ViewBag.db = result3;
                            }
                        }
                        else
                        {
                            ViewBag.db = data.Where(x => x.table == table).ToList();
                        }
                        //Aspnet
                    }
                    else
                    {
                        ViewBag.db = result1;
                    }
                }
                else
                {
                    ViewBag.db = data.Where(x => x.table == table).ToList();
                }
            }
           
            
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}