using App.PathDetail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.PathDetail
{
    public interface IPathDetailService
    {
        List<sitePage> Sitemap(string path);
        List<db_list> get_db_class(string path);
        List<backlist> get_backlist(string path);
    }
}
