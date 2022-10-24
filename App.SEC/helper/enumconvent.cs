using App.SEC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace App.SEC.helper
{
    public  class enumconvent<t>
    {
     
            public List<t>? Data { get; set; }
            private string _file;
            public enumconvent(string file)
            {
                _file = file;
            }
            public List<t>? JsonNetResult()
            {


                //deserialize JSON from file  
                string fileName = System.IO.File.ReadAllText(_file);
                //JavaScriptSerializer ser = new JavaScriptSerializer();
                //var personlist = ser.Deserialize<List<t>>(Json);


                // var jsonString = File.ReadAllText(fileName);


                var result = JsonSerializer.Deserialize<List<t>>(fileName);

                return result;
            }
        }

    
}
