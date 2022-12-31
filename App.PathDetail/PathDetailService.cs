using App.PathDetail.helper;
using App.PathDetail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.PathDetail
{
    public class PathDetailService : IPathDetailService
    {
        public List<backlist> get_backlist(string path)
        {
            var json = new readjson<backlist>(path);

            return json.JsonNetResult()!;
        }

        public List<db_list> get_db_class(string path)
        {
            var json = new readjson<db_list>(path);

            return json.JsonNetResult()!;
        }

        public List<sitePage> Sitemap(string path)
        {
            var json = new readjson<sitePage>(path);

            return json.JsonNetResult()!;
        }
    }
}
