using App.PathDetail;
using App.PathDetail.Models;
using ex_web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static App.PathDetail.Models.d3_model;

namespace ex_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected readonly IPathDetailService _Service;
        protected readonly List<db_list> _db_class;
        protected readonly List<backlist> _backlist;
        public HomeController(ILogger<HomeController> logger, IPathDetailService Service)
        {
            _Service = Service;
            _logger = logger;
            _db_class = _Service.get_db_class("./json/database_class_list.json");
            _backlist = _Service.get_backlist("./json/backlist.json");
        }

        public IActionResult Index()
        {
            ViewBag.db = _db_class;
            return View();
        }
        public IActionResult relation(string table)
        {

            var sub_table = table;
            var data = _db_class;
            var get_backlist = _backlist;
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
        public IActionResult Tree(string table)
        {
            var main = new d3_model();
            var list = new List<Child>();
            var data = _db_class.Where(x => x.table == table).ToList();
            if (data.Count != 0)
            {
                main.name = table;
                foreach (var item in data[0].data)
                {
                    if (item.type == "virtual")
                    {
                        var sub1 = _db_class.Where(x => x.table == item.field).ToList();

                        if (sub1.Count != 0)
                        {

                            var list_sub1 = new List<Child>();
                            foreach (var item1 in sub1[0].data)
                            {
                                if (item1.type == "virtual")
                                {

                                    list_sub1.Add(new Child
                                    {
                                        name = item1.field,
                                        type = item1.type
                                    });
                                }

                            }


                            list.Add(new Child
                            {
                                name = item.field,
                                type = item.type,
                                children = list_sub1

                            });
                        }
                    }

                }
                main.children = list;
            }

            ViewBag.data = main;
            return View();
        }


        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}