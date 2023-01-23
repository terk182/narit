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

        public List<ChartHeader> GetChartAll()
        {
            var data = _databaseACC.ChartHeaders.ToList();
            var result1 = new List<ChartHeader>();

            foreach (var item1 in data)
            {
                var result2 = new List<ChartSubHeader>();
                var Chart2 = _databaseACC.ChartSubHeaders.Where(x => x.ChartHeaderId == item1.Id).ToList();
                foreach (var item2 in Chart2)
                {
                    var result3 = new List<ChartMajor>();
                    var Chart3 = _databaseACC.ChartMajors.Where(x => x.ChartSubHeaderId == item2.Id).ToList();
                    foreach (var item3 in Chart3)
                     {
                        var result4 = new List<ChartSubMajor>();
                        var Chart4 = _databaseACC.ChartSubMajors.Where(x => x.ChartMajorId == item3.Id).ToList();
                        foreach (var item4 in Chart4)
                        {
                            var result5 = new List<ChartMinor>();
                            var Chart5 = _databaseACC.ChartMinors.Where(x => x.ChartSubMajorId == item4.Id).ToList();
                            foreach (var item5 in Chart5)
                            {

                                var result6 = new List<ChartSubMinor>();
                                var Chart6 = _databaseACC.ChartSubMinors.Where(x => x.ChartMinorId == item5.Id).ToList();
                                foreach (var item6 in Chart6)
                                {
                                    result6.Add(new ChartSubMinor
                                    {
                                        Id = item6.Id,
                                        ChartMinorId = item6.ChartMinorId,
                                        ChartSubMinorCode = item6.ChartSubMinorCode,
                                        Name = item6.Name,
                                        Index = item6.Index,
                                        AccTypeId= item6.AccTypeId
                                    });
                                }
                                result5.Add(new ChartMinor
                                {
                                    Id = item5.Id,
                                    ChartSubMajorId = item5.ChartSubMajorId,
                                    ChartMinorCode = item5.ChartMinorCode,
                                    Name = item5.Name,
                                    Index = item5.Index,
                                    AccTypeId = item5.AccTypeId,
                                    ChartSubMinors = result6
                                });
                            }
                            result4.Add(new ChartSubMajor
                            {
                                Id = item4.Id,
                                ChartMajorId = item4.ChartMajorId,
                                ChartSubMajorCode = item4.ChartSubMajorCode,
                                Name = item4.Name,
                                Index = item4.Index,
                                AccTypeId = item4.AccTypeId,
                                ChartMinors = result5
                            });
                        }
                        result3.Add(new ChartMajor
                        {
                            Id = item3.Id,
                            ChartSubHeaderId = item3.ChartSubHeaderId,
                            ChartMajorCode = item3.ChartMajorCode,
                            Name = item3.Name,
                            Index = item3.Index,
                            AccTypeId = item3.AccTypeId,
                            ChartSubMajors = result4
                        });
                    }
                    result2.Add(new ChartSubHeader
                    {
                        Id= item2.Id,
                        ChartHeaderId = item2.ChartHeaderId,
                        ChartSubHeaderCode = item2.ChartSubHeaderCode,
                        Name = item2.Name,
                        Index = item2.Index,
                        AccTypeId = item2.AccTypeId,
                        ChartMajors = result3
                    });
                }
                result1.Add(new ChartHeader
                {
                    Id = item1.Id,
                    ChartHeaderCode = item1.ChartHeaderCode,
                    Name = item1.Name,
                    Index = item1.Index,
                    AccTypeId = item1.AccTypeId,
                    ChartSubHeaders = result2
                });
            }
                return result1;
        }

        // Header 
        public List<ChartResponse> GetChartHeader()
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartHeaders.ToList();
            var accounttypes = _databaseACC.AccountTypes.ToList();
            var QSOuterJoin = from chart in data
                              join acctype in accounttypes
                              on chart.AccTypeId.ToString() equals acctype.Id.ToString()
                              into accchartGroup
                              from nacctype in accchartGroup.DefaultIfEmpty()
                              select new { chart, nacctype };
            foreach (var item in QSOuterJoin)
                result.Add(new ChartResponse
                {
                    Id = item.chart.Id,
                    Code = item.chart.ChartHeaderCode,
                    Name = item.chart?.Name,
                    Active = item.chart.Active,
                    AccTypeId = item.chart.AccTypeId,
                    AccTypeName = item.nacctype.Name,
                    Detail = item.chart.Detail,

                });
            return result;
        }


        public List<ChartResponse> GetChartHeaderId(int id)
        {
          //  var data = _databaseACC.ChartHeaders.Where(x => x.Id == id).ToList();
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartHeaders.Where(x => x.Id == id).ToList();
            var accounttypes = _databaseACC.AccountTypes.ToList();
            var QSOuterJoin = from chart in data
                              join acctype in accounttypes
                              on chart.AccTypeId.ToString() equals acctype.Id.ToString()
                              into accchartGroup
                              from nacctype in accchartGroup.DefaultIfEmpty()
                              select new { chart, nacctype };
            foreach (var item in QSOuterJoin)
                result.Add(new ChartResponse
                {
                    Id = item.chart.Id,
                    Code = item.chart.ChartHeaderCode,
                    Name = item.chart?.Name,
                    Active = item.chart.Active,
                    AccTypeId = item.chart.AccTypeId,
                    AccTypeName = item.nacctype.Name,
                    Detail = item.chart.Detail,
                });
            return result;
        }


        //SubHeader 
        public List<ChartResponse> GetChartSubHeader(int ChartHeaderId)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartSubHeaders.Where(x => x.ChartHeaderId == ChartHeaderId).ToList();
            var accounttypes = _databaseACC.AccountTypes.ToList();
            var QSOuterJoin = from chart in data
                              join acctype in accounttypes
                              on chart.AccTypeId.ToString() equals acctype.Id.ToString()
                              into accchartGroup
                              from nacctype in accchartGroup.DefaultIfEmpty()
                              select new { chart, nacctype };
            foreach (var item in QSOuterJoin)
                result.Add(new ChartResponse
                {
                    Id = item.chart.Id,
                    Code = item.chart.ChartSubHeaderCode,
                    Name = item.chart?.Name,
                    Active = item.chart.Active,
                    AccTypeName = item.nacctype.Name,
                    Detail = item.chart.Detail,
                });
            return result;
        }

        public List<ChartResponse> GetChartSubHeaderId(int id)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartSubHeaders.Where(x => x.Id == id).ToList();
            var accounttypes = _databaseACC.AccountTypes.ToList();
            var QSOuterJoin = from chart in data
                              join acctype in accounttypes
                              on chart.AccTypeId.ToString() equals acctype.Id.ToString()
                              into accchartGroup
                              from nacctype in accchartGroup.DefaultIfEmpty()
                              select new { chart, nacctype };
            foreach (var item in QSOuterJoin)
                result.Add(new ChartResponse
                {
                    Id = item.chart.Id,
                    Code = item.chart.ChartSubHeaderCode,
                    Name = item.chart?.Name,
                    Active = item.chart.Active,
                    AccTypeId = item.chart.AccTypeId,
                    AccTypeName = item.nacctype.Name,
                    Detail = item.chart.Detail,
                });
            return result;
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
        public List<ChartResponse> GetChartMajor(int ChartSubHeaderId)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartMajors.Where(x => x.ChartSubHeaderId == ChartSubHeaderId).ToList();
            var accounttypes = _databaseACC.AccountTypes.ToList();
            var QSOuterJoin = from chart in data
                              join acctype in accounttypes
                              on chart.AccTypeId.ToString() equals acctype.Id.ToString()
                              into accchartGroup
                              from nacctype in accchartGroup.DefaultIfEmpty()
                              select new { chart, nacctype };
            foreach (var item in QSOuterJoin)
                result.Add(new ChartResponse
                {
                    Id = item.chart.Id,
                    Code = item.chart.ChartMajorCode,
                    Name = item.chart?.Name,
                    Active = item.chart.Active,
                    AccTypeName = item.nacctype.Name,
                    Detail = item.chart.Detail,

                });
            return result;

        }

        public List<ChartResponse> GetChartMajorId(int id)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartMajors.Where(x => x.Id == id).ToList();
            var accounttypes = _databaseACC.AccountTypes.ToList();
            var QSOuterJoin = from chart in data
                              join acctype in accounttypes
                              on chart.AccTypeId.ToString() equals acctype.Id.ToString()
                              into accchartGroup
                              from nacctype in accchartGroup.DefaultIfEmpty()
                              select new { chart, nacctype };
            foreach (var item in QSOuterJoin)
                result.Add(new ChartResponse
                {
                    Id = item.chart.Id,
                    Code = item.chart.ChartMajorCode,
                    Name = item.chart?.Name,
                    Active = item.chart.Active,
                    AccTypeId = item.chart.AccTypeId,
                    AccTypeName = item.nacctype.Name,
                    Detail = item.chart.Detail,
                });
            return result;
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
        public List<ChartResponse> GetChartSubMajor(int ChartMajorId)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartSubMajors.Where(x => x.ChartMajorId == ChartMajorId).ToList();
            var accounttypes = _databaseACC.AccountTypes.ToList();
            var QSOuterJoin = from chart in data
                              join acctype in accounttypes
                              on chart.AccTypeId.ToString() equals acctype.Id.ToString()
                              into accchartGroup
                              from nacctype in accchartGroup.DefaultIfEmpty()
                              select new { chart, nacctype };
            foreach (var item in QSOuterJoin)
                result.Add(new ChartResponse
                {
                    Id = item.chart.Id,
                    Code = item.chart.ChartSubMajorCode,
                    Name = item.chart?.Name,
                    Active = item.chart.Active,
                    AccTypeName = item.nacctype.Name,
                    Detail = item.chart.Detail,

                });
            return result;
        }
        public List<ChartResponse> GetChartSubMajorId(int id)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartSubMajors.Where(x => x.Id == id).ToList();
            var accounttypes = _databaseACC.AccountTypes.ToList();
            var QSOuterJoin = from chart in data
                              join acctype in accounttypes
                              on chart.AccTypeId.ToString() equals acctype.Id.ToString()
                              into accchartGroup
                              from nacctype in accchartGroup.DefaultIfEmpty()
                              select new { chart, nacctype };
            foreach (var item in QSOuterJoin)
                result.Add(new ChartResponse
                {
                    Id = item.chart.Id,
                    Code = item.chart.ChartSubMajorCode,
                    Name = item.chart?.Name,
                    Active = item.chart.Active,
                    AccTypeId = item.chart.AccTypeId,
                    AccTypeName = item.nacctype.Name,
                    Detail = item.chart.Detail,
                });
            return result;
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
        public List<ChartResponse> GetChartMinor(int ChartMajorId)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartMinors.Where(x => x.ChartSubMajorId == ChartMajorId).ToList();
            var accounttypes = _databaseACC.AccountTypes.ToList();
            var QSOuterJoin = from chart in data
                              join acctype in accounttypes
                              on chart.AccTypeId.ToString() equals acctype.Id.ToString()
                              into accchartGroup
                              from nacctype in accchartGroup.DefaultIfEmpty()
                              select new { chart, nacctype };
            foreach (var item in QSOuterJoin)
                result.Add(new ChartResponse
                {
                    Id = item.chart.Id,
                    Code = item.chart.ChartMinorCode,
                    Name = item.chart?.Name,
                    Active = item.chart.Active,
                    AccTypeName = item.nacctype.Name,
                    Detail = item.chart.Detail,

                });
            return result;
        }

        public List<ChartResponse> GetChartMinorId(int id)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartMinors.Where(x => x.Id == id).ToList();
            var accounttypes = _databaseACC.AccountTypes.ToList();
            var QSOuterJoin = from chart in data
                              join acctype in accounttypes
                              on chart.AccTypeId.ToString() equals acctype.Id.ToString()
                              into accchartGroup
                              from nacctype in accchartGroup.DefaultIfEmpty()
                              select new { chart, nacctype };
            foreach (var item in QSOuterJoin)
                result.Add(new ChartResponse
                {
                    Id = item.chart.Id,
                    Code = item.chart.ChartMinorCode,
                    Name = item.chart?.Name,
                    Active = item.chart.Active,
                    AccTypeId = item.chart.AccTypeId,
                    AccTypeName = item.nacctype.Name,
                    Detail = item.chart.Detail,
                });
            return result;
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

        public List<ChartResponse> GetChartSubMinor(int ChartMinorId)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartSubMinors.Where(x => x.ChartMinorId == ChartMinorId).ToList();
            var accounttypes = _databaseACC.AccountTypes.ToList();
            var QSOuterJoin = from chart in data
                              join acctype in accounttypes
                              on chart.AccTypeId.ToString() equals acctype.Id.ToString()
                              into accchartGroup
                              from nacctype in accchartGroup.DefaultIfEmpty()
                              select new { chart, nacctype };
            foreach (var item in QSOuterJoin)
                result.Add(new ChartResponse
                {
                    Id = item.chart.Id,
                    Code = item.chart.ChartSubMinorCode,
                    Name = item.chart?.Name,
                    Active = item.chart.Active,
                    AccTypeId = item.chart.AccTypeId,
                    AccTypeName = item.nacctype.Name,
                    Detail = item.chart.Detail,

                });
            return result;
        }
 
 

        public List<ChartResponse> GetChartSubMinorId(int id)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartSubMinors.Where(x => x.Id == id).ToList();
            var accounttypes = _databaseACC.AccountTypes.ToList();
            var QSOuterJoin = from chart in data
                              join acctype in accounttypes
                              on chart.AccTypeId.ToString() equals acctype.Id.ToString()
                              into accchartGroup
                              from nacctype in accchartGroup.DefaultIfEmpty()
                              select new { chart, nacctype };
            foreach (var item in QSOuterJoin)
                result.Add(new ChartResponse
                {
                    Id = item.chart.Id,
                    Code = item.chart.ChartSubMinorCode,
                    Name = item.chart?.Name,
                    Active = item.chart.Active,
                    AccTypeId = item.chart.AccTypeId,
                    AccTypeName = item.nacctype.Name,
                    Detail = item.chart.Detail,
                });
            return result;
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

            }
            return response;
        }

        //AccountType
        public CommonBaseResponse AddAccountType(CreateAccountTypeRequest request)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            CreateAccountTypeRequest account = new CreateAccountTypeRequest();
            account.TypeCode = request.TypeCode;
            account.Active = request.Active;
            account.Name = request.Name;
            account.Detail = request.Detail;

            var accountTypes = _databaseACC.AccountTypes.Where(x => x.TypeCode == request.TypeCode).ToList();
            if (accountTypes.Count == 0)
            {
                _databaseACC.Entry(account).State = EntityState.Added;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Add Complete" : "Data Duplicate";
            }
            return response;
        }
        public CommonBaseResponse EditAccountType(CreateAccountTypeRequest request)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            var accountTypes = _databaseACC.AccountTypes.Where(x => x.TypeCode == request.TypeCode).FirstOrDefault();

            if (accountTypes != null)
            {
                accountTypes.Id = accountTypes.Id;
                accountTypes.Active = request.Active;
                accountTypes.TypeCode = request.TypeCode;
                accountTypes.Name = request.Name;
                accountTypes.Detail = request.Detail;
                _databaseACC.Entry(accountTypes).State = EntityState.Modified;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Add Complete" : "Data Duplicate";
            }

            return response;
        }
        public CommonBaseResponse DeleteAccountTypeId(int id)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            var data = _databaseACC.AccountTypes.Where(x => x.Id == id).FirstOrDefault();
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
        public AccountType GetAccountTypeId(int id)
        {
            AccountType account = _databaseACC.AccountTypes.Where(x => x.Id == id).FirstOrDefault();
            if (account != null)
            {
                return account;
            }
            return account;
        }
        public List<AccountType> GetAccountType()
        {
            List<AccountType> accountTypeList = _databaseACC.AccountTypes.ToList();
            return accountTypeList;
        }

        //DebtorType
        public List<DebtorType> GetDebtorType()
        {
            List<DebtorType> accounts = _databaseACC.DebtorTypes.ToList();
            return accounts;
        }
        public DebtorType GetDebtorTypeId(int id)
        {
            DebtorType account = _databaseACC.DebtorTypes.Where(x => x.Id == id).FirstOrDefault();
            if (account != null)
            {
                return account;
            }
            return account;
        }
        public CommonBaseResponse AddDebtorType(DebtorTypeRequest request)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            DebtorType account = new DebtorType();
            var result = _databaseACC.DebtorTypes.Where(x => x.DebtorTypeCode == request.TypeCode).FirstOrDefault();
            if (result == null)
            {
                account.DebtorTypeCode = request.TypeCode;
                account.Name = request.Name;
                account.Active = request.Active;
                account.Detail = request.Detail;
                _databaseACC.Entry(account).State = EntityState.Added;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "ADD Complete" : "Add Fail";
            }
            return response;
        }
        public CommonBaseResponse EditDebtorType(DebtorTypeRequest request)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            DebtorType account = new DebtorType();
            DebtorType result = _databaseACC.DebtorTypes.Where(x => x.Id == request.Id).FirstOrDefault();
            if (result != null)
            {
                result.DebtorTypeCode = request.TypeCode;
                result.Name = request.Name;
                result.Active = request.Active;
                result.Detail = request.Detail;
                _databaseACC.Entry(result).State = EntityState.Modified;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Edit Complete" : "Edit Fail";
            }
            return response;
        }
        public CommonBaseResponse DeleteDebtorTypeId(int id)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            var data = _databaseACC.DebtorTypes.Where(x => x.Id == id).FirstOrDefault();
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

        //CreditorType
        public List<CreditorType> GetCreditorType()
        {
            List<CreditorType> CreditorTypes = _databaseACC.CreditorTypes.ToList();
            return CreditorTypes;
        }
        public CreditorType GetCreditorTypeId(int id)
        {
            CreditorType CreditorType = _databaseACC.CreditorTypes.Where(x => x.Id == id).FirstOrDefault();
            return CreditorType;
        }
        public CommonBaseResponse AddCreditorType(CreditorTypeRequest request)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            CreditorType accountPayable = new CreditorType();
            var result = _databaseACC.CreditorTypes.Where(x => x.CreditorTypeCode == request.TypeCode).FirstOrDefault();
            if (result == null)
            {
                accountPayable.CreditorTypeCode = request.TypeCode;
                accountPayable.Name = request.Name;
                accountPayable.Active = request.Active;
                accountPayable.Detail = request.Detail;
                _databaseACC.Entry(accountPayable).State = EntityState.Added;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "ADD Complete" : "Add Fail";
            }
            return response;
        }
        public CommonBaseResponse EditCreditorType(CreditorTypeRequest request)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            CreditorType account = new CreditorType();
            CreditorType result = _databaseACC.CreditorTypes.Where(x => x.Id == request.Id).FirstOrDefault();
            if (result != null)
            {
                result.CreditorTypeCode = request.TypeCode;
                result.Name = request.Name;
                result.Active = request.Active;
                result.Detail = request.Detail;
                _databaseACC.Entry(result).State = EntityState.Modified;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Edit Complete" : "Edit Fail";
            }
            return response;
        }
        public CommonBaseResponse DeletetCreditorTypeId(int id)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            var data = _databaseACC.CreditorTypes.Where(x => x.Id == id).FirstOrDefault();
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

        public List<Creditor> GetCreditor()
        {
           List<Creditor> creditor = _databaseACC.Creditors.ToList();
            if(creditor.Count > 0)
            {
                return creditor;
            }
            return creditor;
        }

        public Creditor GetCreditorId(int id) 
        {
            Creditor creditor = _databaseACC.Creditors.Where(x=>x.Id == id).FirstOrDefault();
            if (creditor != null)
            {
                return creditor;
            }
            return creditor;
        }
     
        public CommonBaseResponse AddCreditor(CreditorRequest request)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            Creditor creditor = new Creditor();
            var result = _databaseACC.Creditors.Where(x => x.Name == request.Name).FirstOrDefault();
            if (result == null)
            {
                creditor.Name = request.Name;
                creditor.Address = request.Address;
                creditor.SubDistrict = request.SubDistrict;
                creditor.District = request.District;
                creditor.Province = request.Province;
                creditor.Postcode = request.Postcode;
                creditor.ContactName = request.ContactName;
                creditor.Phone = request.Phone;
                creditor.TaxCode = request.TaxCode;
                creditor.Branch = request.Branch;
                creditor.CreditorTypeId = request.CreditorTypeId;
                creditor.ContactDate = request.ContactDate;
                creditor.BusinessTypeId = request.BusinessTypeId;
                creditor.BankAccountNo = request.BankAccontNo;
                creditor.BankId = request.BankId;
                creditor.CertificateOfPartnershipId = request.CertificateOfPartnershipId;
                creditor.CertificateOfPartnershipDate = request.CertificateOfPartnershipDate;

                _databaseACC.Entry(creditor).State = EntityState.Added;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "ADD Complete" : "Add Fail";
            }
            return response;
        }

        public CommonBaseResponse EditCreditor(CreditorRequest request)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            var result = _databaseACC.Creditors.Where(x => x.Id == request.Id).FirstOrDefault();
            if (result != null)
            {
                result.Name = request.Name;
                result.Active = request.Active;
                result.Address = request.Address;
                result.SubDistrict = request.SubDistrict;
                result.District = request.District;
                result.Province = request.Province;
                result.Postcode = request.Postcode;
                result.ContactName = request.ContactName;
                result.Phone = request.Phone;
                result.TaxCode = request.TaxCode;
                result.Branch = request.Branch;
                result.CreditorTypeId = request.CreditorTypeId;
                result.ContactDate = request.ContactDate;
                result.BusinessTypeId = request.BusinessTypeId;
                result.BankAccountNo = request.BankAccontNo;
                result.BankId = request.BankId;
                result.CertificateOfPartnershipId = request.CertificateOfPartnershipId;
                result.CertificateOfPartnershipDate = request.CertificateOfPartnershipDate;

                _databaseACC.Entry(result).State = EntityState.Modified;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Edit Complete" : "Edit Fail";
            }
            response.Success = false;
            response.Messsage = "Edit Fail : Not Result in DataBase";
            return response;
        }

        public CommonBaseResponse DeleteCreditorId(int id)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            var data = _databaseACC.Creditors.Where(x => x.Id == id).FirstOrDefault();
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
