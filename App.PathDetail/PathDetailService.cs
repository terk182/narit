using App.Common.Models.Responses;
using App.PathDetail.helper;
using App.PathDetail.Models;
using App.PathDetail.Requests;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.PathDetail
{
    public class PathDetailService : IPathDetailService
    {
        private readonly NARIT_MIS_LINKContext _database;
       
        public PathDetailService(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }

        public List<MisSsoMatching> GetMisSsoMatching(MisSsoMatching request)
        {
            var data = _database.MisSsoMatchings.Where(x => x.Active == true && (request.Year > 0 ? x.Year == request.Year : true) &&  (request.MisId >0? x.MisId == request.MisId:true) && (request.SsoId > 0 ? x.SsoId == request.SsoId:true) && (request.SsoName.Length > 1? x.SsoName == request.SsoName :true) && (request.MisName.Length > 1 ? x.MisName == request.MisName :true) ).ToList();
            return data;
        }

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

        public List<MisSsoMatching> search(MisUsers request)
        {
            var _MisSsoMatching = from c in _database.MisSsoMatchings
                                  where request.name.Length > 0 ?  c.MisName.Contains(request.name) :true && request.uid.Length > 0 ? c.SsoUid.Contains(request.uid) : true
                            select c;
            return _MisSsoMatching.ToList();
        }

        public List<StaffSecurityDto> searchStaff(MisUsers request)
        {
            var result = new List<StaffSecurityDto>();
            var _StaffSecurity = from c in _database.StaffSecurities
                                  where request.name.Length > 0 ? c.Name.Contains(request.name) : true && request.uid.Length > 0 ? c.Id == int.Parse( request.uid) : true
                                  select c;

            foreach (var item in _StaffSecurity)
            {
                result.Add(new StaffSecurityDto
                {
                    name = item.Name,
                    MisId = item.Id,
             });
            }
            return result;
        }



        public CommonBaseResponse SetMisSsoMatching(List<MisSsoMatching> request)
        {
            int result = 0;
            var db = new MisSsoMatching();
            foreach (var item in request)
            {
                  db.Id = item.Id;
                db.Active = item.Active;
                    if (item.Type.ToLower() == "reject")
                    {
                        db.Active = false;
                    }

                  db.MisId = item.MisId;
                  db.MisName = item.MisName;
                  db.SsoId = item.SsoId;
                  db.SsoName = item.SsoName;
                  db.Year = item.Year;
                  db.Type = item.Type;
                  db.MisUid = item.MisUid;
                  db.SsoUid = item.SsoUid;
        _database.Entry(db).State = item.Id == 0 ?
                  EntityState.Added :
                  EntityState.Modified;
                result = _database.SaveChanges();
            }
            var response = new CommonBaseResponse();
            response.Success = result > 0 ? true : false;

            return response;
    
        }

        public List<sitePage> Sitemap(string path)
        {
            var json = new readjson<sitePage>(path);

            return json.JsonNetResult()!;
        }
    }
}
