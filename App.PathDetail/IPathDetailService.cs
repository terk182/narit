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
        List<SiteMap> Sitemap(string path);
    }
}
