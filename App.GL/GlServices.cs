using App.Common.Models.Responses;
using App.GL.Requests;
using App.GL.Responses;
using Microsoft.EntityFrameworkCore;
using narit_acc_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App.GL
{
    public class GlServices : IGlServices
    {
        private readonly CGI_ACCContext _databaseACC;

        public GlServices(CGI_ACCContext context)
        {
            _databaseACC = context;
        }


// Header 
        public List<ChartHeader> GetChartHeader()
        {
            var data = _databaseACC.ChartHeaders.ToList();
            return data;
        }

        public List<ChartHeader> GetChartHeaderId(int id)
        {
            var data = _databaseACC.ChartHeaders.Where(x => x.Id == id).ToList();
            return data;
        }

        //SubHeader 
        public List<ChartSubHeader> GetChartSubHeader(int ChartHeaderId)
        {
            var data = _databaseACC.ChartSubHeaders.Where(x => x.ChartHeaderId == ChartHeaderId).ToList();
            return data;
        }

        public List<ChartSubHeader> GetChartSubHeaderId(int id)
        {
            var data = _databaseACC.ChartSubHeaders.Where(x => x.Id == id).ToList();
            return data;
        }
        public CommonBaseResponse AddSubHeader(ChartRequest request)
        {
            var response = new CommonBaseResponse();
            var checkcode = _databaseACC.ChartSubHeaders.Where(x => x.ChartSubHeaderCode == request.Code).FirstOrDefault();
            if (checkcode == null)
            {
                var _SubHeader = new ChartSubHeader();
                _SubHeader.ChartHeaderId = request.BeforeCodeId;
                _SubHeader.ChartSubHeaderCode = request.Code;
                _SubHeader.Name = request.Name;
                _SubHeader.AccTypeId = request.AccTypeId;
                _SubHeader.Detail = request.Detail;

                _databaseACC.Entry(_SubHeader).State = EntityState.Added;
                var result = _databaseACC.SaveChanges();
                response.Success = true;
                response.Messsage = "Add complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "SubHeaderCode";
            }
            return response;
        }

        public CommonBaseResponse EditSubHeader(EditChartRequest request)
        {
            var response = new CommonBaseResponse();
            var checkcode = _databaseACC.ChartSubHeaders.Where(x => x.Id == request.Id).FirstOrDefault();
            if (checkcode == null)
            {
                response.Success = false;
                response.Messsage = " No Data ";
            }
            if (checkcode != null)
            {
                checkcode.ChartHeaderId = request.BeforeCodeId;
                checkcode.ChartSubHeaderCode = request.Code;
                checkcode.Name = request.Name;
                checkcode.AccTypeId = request.AccTypeId;
                checkcode.Detail = request.Detail;
                _databaseACC.Entry(checkcode).State = EntityState.Modified;
                var result = _databaseACC.SaveChanges();
                    response.Success = true;
                    response.Messsage = "Edit complete";
            }
            return response;
        }

        public CommonBaseResponse DelSubHeader(int Id)
        {
            var response = new CommonBaseResponse();
            var data = _databaseACC.ChartSubHeaders.Where(x => x.Id == Id).FirstOrDefault();
            if (data != null)
            {
                data.Active = 0;
                _databaseACC.Entry(data).State = EntityState.Modified;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Delete complete" : "Delete fail";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }
            return response;

        }


//Major
        public List<ChartMajor> GetChartMajor(int ChartSubHeaderId)
        {
            var data = _databaseACC.ChartMajors.Where(x => x.ChartSubHeaderId == ChartSubHeaderId).ToList();
            return data;
        }

        public List<ChartMajor> GetChartMajorId(int id)
        {
            var data = _databaseACC.ChartMajors.Where(x => x.Id == id).ToList();
            return data;
        }

        public CommonBaseResponse AddMajor(ChartRequest request)
        {
            var response = new CommonBaseResponse();
            var checkcode = _databaseACC.ChartMajors.Where(x => x.ChartMajorCode == request.Code).FirstOrDefault();
            if (checkcode == null)
            {
                var _Major = new ChartMajor();
                _Major.ChartSubHeaderId = request.BeforeCodeId;
                _Major.ChartMajorCode = request.Code;
                _Major.Name = request.Name;
                _Major.AccTypeId = request.AccTypeId;
                _Major.Detail = request.Detail;

                _databaseACC.Entry(_Major).State = EntityState.Added;
                var result = _databaseACC.SaveChanges();
                response.Success = true;
                response.Messsage = "Add complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "SubHeaderCode";
            }
            return response;
        }

        public CommonBaseResponse EditMajor(EditChartRequest request)
        {
            var response = new CommonBaseResponse();
            var checkcode = _databaseACC.ChartMajors.Where(x => x.Id == request.Id).FirstOrDefault();
            if (checkcode == null)
            {
                response.Success = false;
                response.Messsage = " No Data ";
            }
            if (checkcode != null)
            {
                checkcode.ChartSubHeaderId = request.BeforeCodeId;
                checkcode.ChartMajorCode = request.Code;
                checkcode.Name = request.Name;
                checkcode.AccTypeId = request.AccTypeId;
                checkcode.Detail = request.Detail;
                _databaseACC.Entry(checkcode).State = EntityState.Modified;
                var result = _databaseACC.SaveChanges();
                response.Success = true;
                response.Messsage = "Edit complete";
            }
            return response;
        }

        public CommonBaseResponse DelMajor(int Id)
        {
            var response = new CommonBaseResponse();
            var data = _databaseACC.ChartMajors.Where(x => x.Id == Id).FirstOrDefault();
            if (data != null)
            {
                data.Active = 0;
                _databaseACC.Entry(data).State = EntityState.Modified;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Delete complete" : "Delete fail";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }
            return response;
        }

        //SubMajor
        public List<ChartSubMajor> GetChartSubMajor(int ChartMajorId)
        {
            var data = _databaseACC.ChartSubMajors.Where(x => x.ChartMajorId == ChartMajorId).ToList();
            return data;
        }
        public List<ChartSubMajor> GetChartSubMajorId(int id)
        {
            var data = _databaseACC.ChartSubMajors.Where(x => x.Id == id).ToList();
            return data;
        }


        public CommonBaseResponse AddSubMajor(ChartRequest request)
        {
            var response = new CommonBaseResponse();
            var checkcode = _databaseACC.ChartSubMajors.Where(x => x.ChartSubMajorCode == request.Code).FirstOrDefault();
            if (checkcode == null)
            {
                var _Major = new ChartSubMajor();
                _Major.ChartMajorId = request.BeforeCodeId;
                _Major.ChartSubMajorCode = request.Code;
                _Major.Name = request.Name;
                _Major.AccTypeId = request.AccTypeId;
                _Major.Detail = request.Detail;

                _databaseACC.Entry(_Major).State = EntityState.Added;
                var result = _databaseACC.SaveChanges();
                response.Success = true;
                response.Messsage = "Add complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "SubHeaderCode";
            }
            return response;
        }

        public CommonBaseResponse EditSubMajor(EditChartRequest request)
        {
            var response = new CommonBaseResponse();
            var checkcode = _databaseACC.ChartSubMajors.Where(x => x.Id == request.Id).FirstOrDefault();
            if (checkcode == null)
            {
                response.Success = false;
                response.Messsage = " No Data ";
            }
            if (checkcode != null)
            {
                checkcode.ChartMajorId = request.BeforeCodeId;
                checkcode.ChartSubMajorCode = request.Code;
                checkcode.Name = request.Name;
                checkcode.AccTypeId = request.AccTypeId;
                checkcode.Detail = request.Detail;
                _databaseACC.Entry(checkcode).State = EntityState.Modified;
                var result = _databaseACC.SaveChanges();
                response.Success = true;
                response.Messsage = "Edit complete";
            }
            return response;
        }

        public CommonBaseResponse DelSubMajor(int Id)
        {
            var response = new CommonBaseResponse();
            var data = _databaseACC.ChartSubMajors.Where(x => x.Id == Id).FirstOrDefault();
            if (data != null)
            {
                data.Active = 0;
                _databaseACC.Entry(data).State = EntityState.Modified;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Delete complete" : "Delete fail";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }
            return response;
        }

        //Minor
        public List<ChartMinor> GetChartMinor(int ChartMajorId)
        {
            var data = _databaseACC.ChartMinors.Where(x => x.ChartSubMajorId == ChartMajorId).ToList();
            return data;
        }

        public List<ChartMinor> GetChartMinorId(int id)
        {
            var data = _databaseACC.ChartMinors.Where(x => x.Id == id).ToList();
            return data;
        }

        public CommonBaseResponse AddMinor(ChartRequest request)
        {
            var response = new CommonBaseResponse();
            var checkcode = _databaseACC.ChartMinors.Where(x => x.ChartMinorCode == request.Code).FirstOrDefault();
            if (checkcode == null)
            {
                var _Major = new ChartMinor();
                _Major.ChartSubMajorId = request.BeforeCodeId;
                _Major.ChartMinorCode = request.Code;
                _Major.Name = request.Name;
                _Major.AccTypeId = request.AccTypeId;
                _Major.Detail = request.Detail;

                _databaseACC.Entry(_Major).State = EntityState.Added;
                var result = _databaseACC.SaveChanges();
                response.Success = true;
                response.Messsage = "Add complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "Duplicates";
            }
            return response;
        }

        public CommonBaseResponse EditMinor(EditChartRequest request)
        {
            var response = new CommonBaseResponse();
            var checkcode = _databaseACC.ChartMinors.Where(x => x.Id == request.Id).FirstOrDefault();
            if (checkcode == null)
            {
                response.Success = false;
                response.Messsage = " No Data ";
            }
            if (checkcode != null)
            {
                checkcode.ChartSubMajorId = request.BeforeCodeId;
                checkcode.ChartMinorCode = request.Code;
                checkcode.Name = request.Name;
                checkcode.AccTypeId = request.AccTypeId;
                checkcode.Detail = request.Detail;
                _databaseACC.Entry(checkcode).State = EntityState.Modified;
                var result = _databaseACC.SaveChanges();
                response.Success = true;
                response.Messsage = "Edit complete";
            }
            return response;
        }

        public CommonBaseResponse DelMinor(int Id)
        {
            var response = new CommonBaseResponse();
            var data = _databaseACC.ChartMinors.Where(x => x.Id == Id).FirstOrDefault();
            if (data != null)
            {
                data.Active = 0;
                _databaseACC.Entry(data).State = EntityState.Modified;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Delete complete" : "Delete fail";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }
            return response;
        }

        //SubMinor

        public List<ChartSubMinor> GetChartSubMinor(int ChartMinorId)
        {
            var data = _databaseACC.ChartSubMinors.Where(x => x.ChartMinorId == ChartMinorId).ToList();
            return data;
        }

        public List<ChartSubMinor> GetChartSubMinorId(int id)
        {
            var data = _databaseACC.ChartSubMinors.Where(x => x.Id == id).ToList();
            return data;
        }
        public CommonBaseResponse AddSubMinor(SubMinorRequest request)
        {
            var response = new CommonBaseResponse();
            var checkcode = _databaseACC.ChartSubMinors.Where(x => x.ChartSubMinorCode == request.Code).FirstOrDefault();
            if (checkcode == null)
            {
                var _SubMinor = new ChartSubMinor();
                _SubMinor.ChartMinorId = request.BeforeCodeId;
                _SubMinor.ChartSubMinorCode = request.Code;
                _SubMinor.Name = request.Name;
                _SubMinor.AccTypeId = request.AccTypeId;
                _SubMinor.Detail = request.Detail;
                _SubMinor.Balance = request.Balance;

                _databaseACC.Entry(_SubMinor).State = EntityState.Added;
                var result = _databaseACC.SaveChanges();
                response.Success = true;
                response.Messsage = "Add complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "Duplicates";
            }
            return response;
        }

        public CommonBaseResponse EditSubMinor(EditSubMinorRequest request)
        {
            var response = new CommonBaseResponse();
            var checkcode = _databaseACC.ChartSubMinors.Where(x => x.Id == request.Id).FirstOrDefault();
            if (checkcode == null)
            {
                response.Success = false;
                response.Messsage = " No Data ";
            }
            if (checkcode != null)
            {
                checkcode.ChartMinorId = request.BeforeCodeId;
                checkcode.ChartSubMinorCode = request.Code;
                checkcode.Name = request.Name;
                checkcode.AccTypeId = request.AccTypeId;
                checkcode.Detail = request.Detail;
                checkcode.Balance = request.Balance;

                _databaseACC.Entry(checkcode).State = EntityState.Modified;
                var result = _databaseACC.SaveChanges();
                response.Success = true;
                response.Messsage = "Edit complete";
            }
            return response;
        }

        public CommonBaseResponse DelSubMinor(int Id)
        {
            var response = new CommonBaseResponse();
            var data = _databaseACC.ChartSubMinors.Where(x => x.Id == Id).FirstOrDefault();
            if (data != null)
            {
                data.Active = 0;
                _databaseACC.Entry(data).State = EntityState.Modified;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Delete complete" : "Delete fail";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }
            return response;
        }

    }
}
