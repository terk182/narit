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
            var list1 = new List<List<Child>>();
            var _Child = new Child();
            var data = _db_class.Where(x => x.table == table).FirstOrDefault();
            if (data.data.Count != 0)
            {
                foreach(var item in data.data)
                {
                    if (item.type == "virtual")
                    {
                        list.Add(check_tree(item.field));
                    }

                }



            }
         
            main.children = list;
            main.name = table;
            var _main = main;
            string jsonString = JsonSerializer.Serialize(main);
            //var json = new JavaScriptSerializer().Serialize(_main);
            ViewBag.data = jsonString;
            // ViewBag.data = main;
            return View();
        }


        public Child  check_tree(string table)
        {
            var result = new Child();
            var list = new List<Child>();
            string gg = backlist(table);
            var data = _db_class.Where(x => x.table == gg).FirstOrDefault();
            if(data != null)
            {
                foreach (var item in data.data)
                {

            
                    if (item.type == "virtual")
                    {
                        
                        if (item.field != gg)
                        {
                            if (table_c != gg)
                            {
                                table_c = table;
                                list.Add(new Child
                                {
                                    name = item.field,
                                    type = item.type,
                                    children = check_tree(item.field).children

                                });
                            }

                        }
                       

                        
                    }

                }
                if(list.Count == 0)
                {
                    list.Add(new Child
                    {
                        name = table,
                        type = "end",


                    });
                }
            }
            else
            {
                list.Add(new Child
                {
                    name = table,
                    type = "end",


                });
            }
            result.name= table;
            result.children = list;
            return result;
        }
         public string backlist(string table)
        {
            var get_backlist = _backlist;
            var data = _db_class;
          
            string nane = table;
            foreach (var backlist in get_backlist)
            {
                if (table == backlist.name)
                {
                    nane = backlist.target;
                    break;

                }
            }
            return nane;

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}