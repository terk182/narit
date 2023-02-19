using App.Common.Models.Responses;
using App.PathDetail.Models;
using App.PathDetail.Requests;
using narit_mis_api.Models;
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
        CommonBaseResponse SetMisSsoMatching(List<MisSsoMatching> request);
        List<MisSsoMatching> GetMisSsoMatching(MisSsoMatching request);
        List<MisSsoMatching> search(MisUsers request);
        List<StaffSecurityDto> searchStaff(MisUsers request);

        CommonBaseResponse SetMisAccMatching(List<MisAccMatching> request);
        List<MisAccMatching> GetMisAccMatching(MisAccMatching request);

        CommonBaseResponse SetMisProcureItemMatching(List<MisProcureMatching> request);
        List<MisProcureMatching> GetMisProcureItemMatching(MisProcureMatching request);
    }
    
}
