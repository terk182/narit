using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace App.PathDetail.helper
{
    public class readjson<t>
    {
        public List<t>? Data { get; set; }
        private string _file;
        public readjson(string file)
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
