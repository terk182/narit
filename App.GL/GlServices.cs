using App.Common.Models.Responses;
using App.GL.DTO;
using App.GL.Requests;
using App.GL.Responses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic;
using narit_acc_api.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

                                result5.Add(new ChartMinor
                                {
                                    Id = item5.Id,
                                    ChartSubMajorId = item5.ChartSubMajorId,
                                    ChartMinorCode = item5.ChartMinorCode,
                                    Name = item5.Name,
                                    Index = item5.Index,
                                    AccTypeId = item5.AccTypeId,
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
                        Id = item2.Id,
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
                    Index = item.chart.Index


                });
            return result;
        }


        public List<ChartResponse> GetChartHeaderId(int Id)
        {
            //  var data = _databaseACC.ChartHeaders.Where(x => x.Id == id).ToList();
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartHeaders.Where(x => x.Id == Id).ToList();
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
                    Index = item.chart.Index
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
                    Index = item.chart.Index
                });
            return result;
        }

        public List<ChartResponse> GetChartSubHeaderId(int Id)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartSubHeaders.Where(x => x.Id == Id).ToList();
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
                    Index = item.chart.Index
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
                    Index = item.chart.Index

                });
            return result;

        }

        public List<ChartResponse> GetChartMajorId(int Id)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartMajors.Where(x => x.Id == Id).ToList();
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
                    Index = item.chart.Index
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
                    Index = item.chart.Index

                });
            return result;
        }
        public List<ChartResponse> GetChartSubMajorId(int Id)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartSubMajors.Where(x => x.Id == Id).ToList();
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
                    Index = item.chart.Index
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
        public List<ChartMinor> GetAllChartMinor()
        {
            List<ChartMinor> ChartMinors = _databaseACC.ChartMinors.ToList();
            return ChartMinors;
        }
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
                    Index = item.chart.Index

                });
            return result;
        }

        public List<ChartResponse> GetChartMinorId(int Id)
        {
            var result = new List<ChartResponse>();
            var data = _databaseACC.ChartMinors.Where(x => x.Id == Id).ToList();
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
                    Index = item.chart.Index
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

        //public List<ChartSubMinor> GetAllChartSubMinor()
        //{
        //    List<ChartSubMinor> ChartSubMinors = _databaseACC.ChartSubMinors.ToList();
        //    return ChartSubMinors;
        //}

        //public List<ChartResponse> GetChartSubMinor(int ChartMinorId)
        //{
        //    var result = new List<ChartResponse>();
        //    var data = _databaseACC.ChartSubMinors.Where(x => x.ChartMinorId == ChartMinorId).ToList();
        //    var accounttypes = _databaseACC.AccountTypes.ToList();
        //    var QSOuterJoin = from chart in data
        //                      join acctype in accounttypes
        //                      on chart.AccTypeId.ToString() equals acctype.Id.ToString()
        //                      into accchartGroup
        //                      from nacctype in accchartGroup.DefaultIfEmpty()
        //                      select new { chart, nacctype };
        //    foreach (var item in QSOuterJoin)
        //        result.Add(new ChartResponse
        //        {
        //            Id = item.chart.Id,
        //            Code = item.chart.ChartSubMinorCode,
        //            Name = item.chart?.Name,
        //            Active = item.chart.Active,
        //            AccTypeId = item.chart.AccTypeId,
        //            AccTypeName = item.nacctype.Name,
        //            Detail = item.chart.Detail,
        //            Index = item.chart.Index

        //        });
        //    return result;
        //}



        //public List<ChartResponse> GetChartSubMinorId(int id)
        //{
        //    var result = new List<ChartResponse>();
        //    var data = _databaseACC.ChartSubMinors.Where(x => x.Id == id).ToList();
        //    var accounttypes = _databaseACC.AccountTypes.ToList();
        //    var QSOuterJoin = from chart in data
        //                      join acctype in accounttypes
        //                      on chart.AccTypeId.ToString() equals acctype.Id.ToString()
        //                      into accchartGroup
        //                      from nacctype in accchartGroup.DefaultIfEmpty()
        //                      select new { chart, nacctype };
        //    foreach (var item in QSOuterJoin)
        //        result.Add(new ChartResponse
        //        {
        //            Id = item.chart.Id,
        //            Code = item.chart.ChartSubMinorCode,
        //            Name = item.chart?.Name,
        //            Active = item.chart.Active,
        //            AccTypeId = item.chart.AccTypeId,
        //            AccTypeName = item.nacctype.Name,
        //            Detail = item.chart.Detail,
        //            Index = item.chart.Index
        //        });
        //    return result;
        //}

        //public CommonBaseResponse AddSubMinor(SubMinorRequest request)
        //{
        //    var response = new CommonBaseResponse();
        //    var checkcode = _databaseACC.ChartSubMinors.Where(x => x.ChartSubMinorCode == request.Code).FirstOrDefault();
        //    if (checkcode == null)
        //    {
        //        var _SubMinor = new ChartSubMinor();
        //        _SubMinor.ChartMinorId = request.BeforeCodeId;
        //        _SubMinor.ChartSubMinorCode = request.Code;
        //        _SubMinor.Name = request.Name;
        //        _SubMinor.AccTypeId = request.AccTypeId;
        //        _SubMinor.Detail = request.Detail;
        //        _SubMinor.Balance = request.Balance;

        //        _databaseACC.Entry(_SubMinor).State = EntityState.Added;
        //        var result = _databaseACC.SaveChanges();
        //        response.Success = true;
        //        response.Messsage = "Add complete";
        //    }
        //    else
        //    {
        //        response.Success = false;
        //        response.Messsage = "Duplicates";
        //    }
        //    return response;
        //}
        //public CommonBaseResponse EditSubMinor(EditSubMinorRequest request)
        //{
        //    var response = new CommonBaseResponse();
        //    var checkcode = _databaseACC.ChartSubMinors.Where(x => x.Id == request.Id).FirstOrDefault();
        //    if (checkcode == null)
        //    {
        //        response.Success = false;
        //        response.Messsage = " No Data ";
        //    }
        //    if (checkcode != null)
        //    {
        //        checkcode.ChartMinorId = request.BeforeCodeId;
        //        checkcode.ChartSubMinorCode = request.Code;
        //        checkcode.Name = request.Name;
        //        checkcode.AccTypeId = request.AccTypeId;
        //        checkcode.Detail = request.Detail;
        //        checkcode.Balance = request.Balance;

        //        _databaseACC.Entry(checkcode).State = EntityState.Modified;
        //        var result = _databaseACC.SaveChanges();
        //        response.Success = true;
        //        response.Messsage = "Edit complete";
        //    }
        //    return response;
        //}
        //public CommonBaseResponse DelSubMinor(int Id)
        //{
        //    var response = new CommonBaseResponse();
        //    var data = _databaseACC.ChartSubMinors.Where(x => x.Id == Id).FirstOrDefault();
        //    if (data != null)
        //    {
        //        data.Active = 0;
        //        _databaseACC.Entry(data).State = EntityState.Modified;
        //        int returnValue = _databaseACC.SaveChanges();
        //        response.Success = returnValue > 0 ? true : false;
        //        response.Messsage = returnValue > 0 ? "Delete complete" : "Delete fail";
        //    }
        //    else
        //    {

        //    }
        //    return response;
        //}

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
        public CommonBaseResponse DeleteAccountTypeId(int Id)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            var data = _databaseACC.AccountTypes.Where(x => x.Id == Id).FirstOrDefault();
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
        public AccountType GetAccountTypeId(int Id)
        {
            AccountType account = _databaseACC.AccountTypes.Where(x => x.Id == Id).FirstOrDefault();
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
        public DebtorType GetDebtorTypeId(int Id)
        {
            DebtorType account = _databaseACC.DebtorTypes.Where(x => x.Id == Id).FirstOrDefault();
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
        public CommonBaseResponse DeleteDebtorTypeId(int Id)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            var data = _databaseACC.DebtorTypes.Where(x => x.Id == Id).FirstOrDefault();
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



        //Debtor

        public List<DebtorCreditorResponse> GetAllDebtor()
        {
            var Debtor = _databaseACC.Debtors.ToList();

            var result = new List<DebtorCreditorResponse>();
            var data = _databaseACC.Debtors.ToList();
            var debtor = _databaseACC.DebtorTypes.ToList();
            var QSOuterJoin = from datas in data
                              join debtorname in debtor
                              on datas.DebtorTypeId.ToString() equals debtorname.Id.ToString()
                              into datadebtor
                              from nacctype in datadebtor.DefaultIfEmpty()
                              select new { datas, nacctype };
            foreach (var item in QSOuterJoin)
                result.Add(new DebtorCreditorResponse
                {
                    Id = item.datas.Id,
                    Code = item.datas.DebtorCode,
                    Name = item.datas.Name,
                    TypeId = item.datas.DebtorTypeId,
                    Type = item.nacctype.Name,
                    Active = item.datas.Active
                });
            return result;
        }


        //CreditorType
        public List<CreditorType> GetCreditorType()
        {
            List<CreditorType> CreditorTypes = _databaseACC.CreditorTypes.ToList();
            return CreditorTypes;
        }
        public CreditorType GetCreditorTypeId(int Id)
        {
            CreditorType CreditorType = _databaseACC.CreditorTypes.Where(x => x.Id == Id).FirstOrDefault();
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
        public CommonBaseResponse DeletetCreditorTypeId(int Id)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            var data = _databaseACC.CreditorTypes.Where(x => x.Id == Id).FirstOrDefault();
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
            if (creditor.Count > 0)
            {
                return creditor;
            }
            return creditor;
        }

        public Creditor GetCreditorId(int Id)
        {
            Creditor creditor = _databaseACC.Creditors.Where(x => x.Id == Id).FirstOrDefault();
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

        public CommonBaseResponse DeleteCreditorId(int Id)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            var data = _databaseACC.Creditors.Where(x => x.Id == Id).FirstOrDefault();
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

        //Transection
        public List<TransectionResponse> GetTransection()
        {

            {
                var result = new List<TransectionResponse>();
                var data = _databaseACC.Transections.ToList();
                var Transections = _databaseACC.TransectionTypes.ToList();
                var subminors = _databaseACC.ChartMinors.ToList();
                var subjournal = _databaseACC.SubJournals.ToList();
                var QSOuterJoin = from Tran in data
                                  join Transectiontype in Transections
                                  on Tran.TransectionTypeId.ToString() equals Transectiontype.Id.ToString()
                                  into TransectionGroup
                                  from Trantype in TransectionGroup.DefaultIfEmpty()

                                  join submicredit in subminors
                                  on Tran.Credit.ToString() equals submicredit.Id.ToString()
                                  into CreditGroup
                                  from ncredit in CreditGroup.DefaultIfEmpty()

                                  join submicredit in subminors
                                  on Tran.Debit.ToString() equals submicredit.Id.ToString()
                                  into DebittGroup
                                  from ncdebitt in DebittGroup.DefaultIfEmpty()

                                  join submijournal in subjournal
                                  on Tran.SubJournalId.ToString() equals submijournal.Id.ToString()
                                  into SubJournalGroup
                                  from nsubjournal in SubJournalGroup.DefaultIfEmpty()

                                  select new { Tran, Trantype, ncredit, ncdebitt, nsubjournal };
                foreach (var item in QSOuterJoin)
                    result.Add(new TransectionResponse
                    {
                        Id = item.Tran.Id,
                        CreateDate = item.Tran.CreateDate,
                        Detail = item.Tran.Detail,
                        Quantity = item.Tran.Quantity,
                        PaymentTypeId = item.Tran.PaymentTypeId,
                        DebtorTypeId = item.Tran.DebtorTypeId,
                        TransectionTypeId = item.Tran.TransectionTypeId,
                        RefNo = item.Tran.RefNo,
                        DebtorCode = item.Tran.DebtorCode,
                        DetailName = item.Tran.DetailName,
                        TransectionTypeName = item.Trantype.Name,
                        DetailDate = item.Tran.DetailDate,
                        Credit = item.Tran.Credit,
                        CreditName = item.ncredit.Name,
                        Debit = item.Tran.Debit,
                        DebitName = item.ncdebitt.Name,
                        SubJournalId = item.Tran.SubJournalId,
                        SubJournalName = item.nsubjournal.Name,
                        Status = item.Tran.Status

                    });
                return result;
            }
        }

        public List<TransectionResponse> GetTransectionId(int Id)
        {
            var result = new List<TransectionResponse>();
            var data = _databaseACC.Transections.Where(x => x.Id == Id).ToList();
            var Transections = _databaseACC.TransectionTypes.ToList();
            var subminors = _databaseACC.ChartMinors.ToList();
            var subjournal = _databaseACC.SubJournals.ToList();
            var QSOuterJoin = from Tran in data
                              join Transectiontype in Transections
                              on Tran.TransectionTypeId.ToString() equals Transectiontype.Id.ToString()
                              into TransectionGroup
                              from Trantype in TransectionGroup.DefaultIfEmpty()

                              join submicredit in subminors
                              on Tran.Credit.ToString() equals submicredit.Id.ToString()
                              into CreditGroup
                              from ncredit in CreditGroup.DefaultIfEmpty()

                              join submicredit in subminors
                              on Tran.Debit.ToString() equals submicredit.Id.ToString()
                              into DebittGroup
                              from ndebit in DebittGroup.DefaultIfEmpty()

                              join submijournal in subjournal
                              on Tran.SubJournalId.ToString() equals submijournal.Id.ToString()
                              into SubJournalGroup
                              from nsubjournal in SubJournalGroup.DefaultIfEmpty()



                              select new { Tran, Trantype, ncredit, ndebit, nsubjournal };
            foreach (var item in QSOuterJoin)
                result.Add(new TransectionResponse
                {
                    Id = item.Tran.Id,
                    CreateDate = item.Tran.CreateDate,
                    Detail = item.Tran.Detail,
                    Quantity = item.Tran.Quantity,
                    PaymentTypeId = item.Tran.PaymentTypeId,
                    DebtorTypeId = item.Tran.DebtorTypeId,
                    TransectionTypeId = item.Tran.TransectionTypeId,
                    RefNo = item.Tran.RefNo,
                    DebtorCode = item.Tran.DebtorCode,
                    DetailName = item.Tran.DetailName,
                    TransectionTypeName = item.Trantype.Name,
                    DetailDate = item.Tran.DetailDate,
                    Credit = item.Tran.Credit,
                    CreditName = item.ncredit.Name,
                    Debit = item.Tran.Debit,
                    DebitName = item.ndebit.Name,
                    JournalId = item.nsubjournal.JournalId,
                    SubJournalId = item.Tran.SubJournalId,
                    SubJournalName = item.nsubjournal.Name,
                    Status = item.Tran.Status
                });
            return result;
        }

        public CommonBaseResponse EditTransection(EditTransectionRequest request)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            Transection result = _databaseACC.Transections.Where(x => x.Id == request.Id).FirstOrDefault();
            if (result != null)
            {
                result.Detail = result.Detail;
                result.Quantity = result.Quantity;
                result.PaymentTypeId = result.PaymentTypeId;
                result.DebtorTypeId = result.DebtorTypeId;
                result.TransectionTypeId = result.TransectionTypeId;
                result.DetailDate = result.DetailDate;
                result.RefNo = result.RefNo;

                result.Debit = request.Debit;
                result.Credit = request.Credit;
                result.Status = request.Status;
                result.SubJournalId = request.SubJournalId;
                _databaseACC.Entry(result).State = EntityState.Modified;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Edit Complete" : "Edit Fail";
            }
            return response;
        }

        public List<Journal> GetJournal()
        {
            List<Journal> Journal = _databaseACC.Journals.ToList();
            return Journal;
        }

        public List<Journal> GetJournalID(int Id)
        {
            List<Journal> Journal = _databaseACC.Journals.Where(x => x.Id == Id).ToList();
            return Journal;
        }

        public List<SubJournal> GetSubJournal(int JournalID)
        {
            var result = new List<SubJournal>();
            var data = _databaseACC.SubJournals.Where(x => x.JournalId == JournalID).ToList();
            var Journals = _databaseACC.Journals.ToList();
            var QSOuterJoin = from datas in data
                              join Journalname in Journals
                              on datas.JournalId.ToString() equals Journalname.Id.ToString()
                              into datasubjournals
                              from nsubjournal in datasubjournals.DefaultIfEmpty()
                              select new {datas, nsubjournal};
            foreach (var item in QSOuterJoin)
                result.Add(new SubJournal
                {
                    Id = item.datas.Id,
                    Code = item.nsubjournal.Code+item.datas.Code,
                    Name = item.datas.Name,
                    Active = item.datas.Active
                });
            return result;
        }

        public List<SubJournalDto> GetSubJournalID(int Id)
        {
            var SubJournal = _databaseACC.SubJournals.ToList();
            var result = new List<SubJournalDto>();
            var data = _databaseACC.SubJournals.Where(x => x.Id == Id).ToList();
            var Journals = _databaseACC.Journals.ToList();
            var QSOuterJoin = from datas in data
                              join Journalname in Journals
                              on datas.JournalId.ToString() equals Journalname.Id.ToString()
                              into datasubjournals
                              from nsubjournal in datasubjournals.DefaultIfEmpty()
                              select new { datas, nsubjournal };
            foreach (var item in QSOuterJoin)
                result.Add(new SubJournalDto
                {
                    Id = item.datas.Id,
                    JournalCode = item.nsubjournal.Code,
                    JournalName = item.nsubjournal.Name,
                    SubJournalCode = item.datas.Code,
                    SubJournalName = item.datas.Name,
                    Year= item.datas.Year,
                    Month= item.datas.Month,
                    Number= item.datas.Number

                });
            return result;
        }

        public CommonBaseResponse AddSubJournal(SubJournalResponse request)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            SubJournal SubJournal = new SubJournal();

            SubJournal result = _databaseACC.SubJournals.Where(x => x.Code == request.Code & x.JournalId == request.JournalId).FirstOrDefault();
            if (result == null)
            {
                SubJournal.Code = request.Code;
                SubJournal.Name = request.Name;
                SubJournal.JournalId = request.JournalId;
                SubJournal.Year = DateTime.Now.Year.ToString();
                SubJournal.Month = DateTime.Now.Month.ToString();
                SubJournal.Number = request.Number;

                _databaseACC.Entry(SubJournal).State = EntityState.Added;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Add Complete" : "Add Fail";
            }
            else
            {
                response.Success = false;
                response.Messsage = "Error SubJournal";
            }
            return response;
        }

        public CommonBaseResponse EditSubJournal(SubJournalDto request)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            SubJournal result = _databaseACC.SubJournals.Where(x => x.Id == request.Id).FirstOrDefault();
            if (result != null)
            {
                result.Code = request.SubJournalCode;
                result.Name = request.SubJournalName;
                result.Year = result.Year;
                result.Month = result.Month;
                result.Number = request.Number;
                _databaseACC.Entry(result).State = EntityState.Modified;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Edit Complete" : "Edit Fail";
            }
            return response;
        }

        public List<Accounting> ReportGlAll()
        {
            List<Accounting> Journal = _databaseACC.Accountings.ToList();
            return Journal;
        }
        ////public List<Accounting> reportchart(DateTime? DetailDate, int? MinorID)
        ////{
        ////    //var result = new List<Accounting>();

        ////    var data = _databaseACC.Accountings.Where(c => ( c.Credit == MinorID || c.Debit == MinorID) && c.DetailDate == DetailDate).ToList();
        ////    return data;
        ////}

        public ReportChartResponse reportchartdate(ReportChartRequest request)
        {
            ReportChartResponse response = new ReportChartResponse();

            List<Accounting> result1 = new List<Accounting>();
            var ChartMinorId = request.ChartMinorId;
            foreach (var item in ChartMinorId)
            {

                var data = _databaseACC.Accountings.Where(m => (m.Credit == item.Id || m.Debit == item.Id) && m.RefDocDate >= request.FromDate && m.RefDocDate <= request.ToDate);
               // List<Accounting> data2 = _databaseACC.Accountings.Where(m => (m.Credit == item.Id || m.Debit == item.Id) && m.RefDocDate >= request.FromDate && m.RefDocDate <= request.ToDate).ToList();
               // var aaa = data2.Sum(m => m.Quantity);

                foreach (var item1 in data)
                {
                    result1.Add(item1); 
                    //result1.Add(new Accounting
                    //{
                    //    Id = item.Id,
                    //    Quantity = item.Quantity,
                    //    Debit = item.Debit,
                    //    Credit = item.Credit,
                    //    DetailDate = item.DetailDate
                    //});

                }
                //var sumQty = result1.Sum(m => m.Quantity);
                var sumDebit = result1.Where(x =>x.Credit == 0).Sum(x =>x.Quantity);
                var sumCredit = result1.Where(x => x.Debit == 0).Sum(x => x.Quantity);
                response.AllDay = (request.FromDate) + (" to ") + (request.ToDate);
                response.SumDebit = sumDebit;
                response.SumCredit = sumCredit;
                // response.SumQuantity = sumQty;
                response.SumQuantity = (-sumDebit)+(sumCredit);

                if (request.OrderBy == "ASC")
                {
                    string ccc = request.Column.ToString();
                    response.data = result1.OrderBy(x => x.RefDocDate).ToList();
                }
                if (request.OrderBy == "DESC")
                {
                    response.data = result1.OrderByDescending(x => x.RefDocDate).ToList();
                }

            }
            return response;
        }

        public ReportChartResponse PostReportGlDate(ReportChartRequest request)
        {
            ReportChartResponse response = new ReportChartResponse();
            var result1 = new List<Accounting>();
            var today = DateAndTime.Today;
            var ChartMinorId = request.ChartMinorId;

            if (request.SelectDate == 1)
            {
                foreach (var item in ChartMinorId)
                {
                    var data = _databaseACC.Accountings.Where(m => (m.Credit == item.Id || m.Debit == item.Id) && m.RefDocDate >= request.FromDate && m.RefDocDate <= request.ToDate);

                    foreach (var item1 in data)
                    {
                        result1.Add(item1);
                    }
                    var sumQty = result1.Sum(m => m.Quantity);
                    response.AllDay = (request.FromDate) + (" to ") + (request.ToDate);
                    var sumDebit = result1.Where(x => x.Credit == 0).Sum(x => x.Quantity);
                    var sumCredit = result1.Where(x => x.Debit == 0).Sum(x => x.Quantity);
                    response.AllDay = (request.FromDate) + (" to ") + (request.ToDate);
                    response.SumDebit = sumDebit;
                    response.SumCredit = sumCredit;
                    response.SumQuantity = (-sumDebit) + (sumCredit);

                    if (request.OrderBy == "ASC")
                    {
                        response.data = result1.OrderBy(x => x.RefDocDate).ToList();
                    }
                    if (request.OrderBy == "DESC")
                    {
                        response.data = result1.OrderByDescending(x => x.RefDocDate).ToList();
                    }
                }



            }

            if (request.SelectDate == 2)
            {
                var mmm = today.Month - 1;
                if (mmm < 0)
                {
                    foreach (var item in ChartMinorId)
                    {
                        var startmonth = new DateTime(today.Year - 1, 12 + mmm, 1);
                        int daysInMonth = DateTime.DaysInMonth(today.Year, today.Month);
                        var lastmonth = new DateTime(today.Year, today.Month, daysInMonth);
                        var data = _databaseACC.Accountings.Where(m => (m.Credit == item.Id || m.Debit == item.Id) && m.RefDocDate >= startmonth && m.RefDocDate <= lastmonth);

                        foreach (var item1 in data)
                        {
                            result1.Add(item1);
                        }
                        var sumQty = result1.Sum(m => m.Quantity);
                        response.AllDay = (request.FromDate) + (" to ") + (request.ToDate);
                        var sumDebit = result1.Where(x => x.Credit == 0).Sum(x => x.Quantity);
                        var sumCredit = result1.Where(x => x.Debit == 0).Sum(x => x.Quantity);
                        response.AllDay = (request.FromDate) + (" to ") + (request.ToDate);
                        response.SumDebit = sumDebit;
                        response.SumCredit = sumCredit;
                        response.SumQuantity = (-sumDebit) + (sumCredit);

                        if (request.OrderBy == "ASC")
                        {
                            response.data = result1.OrderBy(x => x.RefDocDate).ToList();
                        }
                        if (request.OrderBy == "DESC")
                        {
                            response.data = result1.OrderByDescending(x => x.RefDocDate).ToList();
                        }
                    }

                }

                else
                {
                    foreach (var item in ChartMinorId)
                    {
                        var startmonth = new DateTime(today.Year, today.Month - 1, 1);
                        int daysInMonth = DateTime.DaysInMonth(today.Year, today.Month);
                        var lastmonth = new DateTime(today.Year, today.Month, daysInMonth);
                        var data = _databaseACC.Accountings.Where(m => (m.Credit == item.Id || m.Debit == item.Id) && m.RefDocDate >= startmonth && m.RefDocDate <= lastmonth);
                        foreach (var item1 in data)
                        {
                            result1.Add(item1);
                        }
                        var sumQty = result1.Sum(m => m.Quantity);
                        response.AllDay = (request.FromDate) + (" to ") + (request.ToDate);
                        var sumDebit = result1.Where(x => x.Credit == 0).Sum(x => x.Quantity);
                        var sumCredit = result1.Where(x => x.Debit == 0).Sum(x => x.Quantity);
                        response.AllDay = (request.FromDate) + (" to ") + (request.ToDate);
                        response.SumDebit = sumDebit;
                        response.SumCredit = sumCredit;
                        response.SumQuantity = (-sumDebit) + (sumCredit);

                        if (request.OrderBy == "ASC")
                        {
                            response.data = result1.OrderBy(x => x.RefDocDate).ToList();
                        }
                        if (request.OrderBy == "DESC")
                        {
                            response.data = result1.OrderByDescending(x => x.RefDocDate).ToList();
                        }

                    }
                }
            }

            if (request.SelectDate == 3)
            {
                var mmm = today.Month - 3;
                if (mmm < 0)
                {
                    foreach (var item in ChartMinorId)
                    {
                        var startmonth = new DateTime(today.Year - 1, 12 + mmm, 1);
                        int daysInMonth = DateTime.DaysInMonth(today.Year, today.Month);
                        var lastmonth = new DateTime(today.Year, today.Month, daysInMonth);
                        var data = _databaseACC.Accountings.Where(m => (m.Credit == item.Id || m.Debit == item.Id) && m.RefDocDate >= startmonth && m.RefDocDate <= lastmonth);
                        foreach (var item1 in data)
                        {
                            result1.Add(item1);
                        }
                        var sumQty = result1.Sum(m => m.Quantity);
                        response.AllDay = (request.FromDate) + (" to ") + (request.ToDate);
                        var sumDebit = result1.Where(x => x.Credit == 0).Sum(x => x.Quantity);
                        var sumCredit = result1.Where(x => x.Debit == 0).Sum(x => x.Quantity);
                        response.AllDay = (request.FromDate) + (" to ") + (request.ToDate);
                        response.SumDebit = sumDebit;
                        response.SumCredit = sumCredit;
                        response.SumQuantity = (-sumDebit) + (sumCredit);

                        if (request.OrderBy == "ASC")
                        {
                            response.data = result1.OrderBy(x => x.RefDocDate).ToList();
                        }
                        if (request.OrderBy == "DESC")
                        {
                            response.data = result1.OrderByDescending(x => x.RefDocDate).ToList();
                        }
                    }


                }

                else
                {
                    foreach (var item in ChartMinorId)
                    {
                        var startmonth = new DateTime(today.Year, today.Month - 3, 1);
                        int daysInMonth = DateTime.DaysInMonth(today.Year, today.Month);
                        var lastmonth = new DateTime(today.Year, today.Month, daysInMonth);
                        var data = _databaseACC.Accountings.Where(m => (m.Credit == item.Id || m.Debit == item.Id) && m.RefDocDate >= startmonth && m.RefDocDate <= lastmonth);
                        foreach (var item1 in data)
                        {
                            result1.Add(item1);
                        }
                        var sumQty = result1.Sum(m => m.Quantity);
                        response.AllDay = (request.FromDate) + (" to ") + (request.ToDate);
                        var sumDebit = result1.Where(x => x.Credit == 0).Sum(x => x.Quantity);
                        var sumCredit = result1.Where(x => x.Debit == 0).Sum(x => x.Quantity);
                        response.AllDay = (request.FromDate) + (" to ") + (request.ToDate);
                        response.SumDebit = sumDebit;
                        response.SumCredit = sumCredit;
                        response.SumQuantity = (-sumDebit) + (sumCredit);

                        if (request.OrderBy == "ASC")
                        {
                            response.data = result1.OrderBy(x => x.RefDocDate).ToList();
                        }
                        if (request.OrderBy == "DESC")
                        {
                            response.data = result1.OrderByDescending(x => x.RefDocDate).ToList();
                        }

                    }
                }
            }

            return response;
        }

        /// Document
        public List<DocumentType> GetDocumentType()
        {
            List<DocumentType> DocumentType = _databaseACC.DocumentTypes.ToList();
            return DocumentType;
        }

        public List<DocumentResponse> GetDocument(int Active)
        {
            //List<Document> Document = _databaseACC.Documents.ToList();
            //return Document;

            var result = new List<DocumentResponse>();
            var data = _databaseACC.Documents.Where(x => x.Active == Active).ToList();
            var DocumentType = _databaseACC.DocumentTypes.ToList();
            var journal = _databaseACC.Journals.ToList();
            var subjournal = _databaseACC.SubJournals.ToList();
            var QSOuterJoin = from datas in data
                              join DocumentTypelname in DocumentType
                              on datas.DocumentTypeId.ToString() equals DocumentTypelname.Id.ToString()
                              into dataDocuments
                              from ndocumenttypes in dataDocuments.DefaultIfEmpty()

                              join journalname in journal
                              on datas.JournalId.ToString() equals journalname.Id.ToString()
                              into journalGroup
                              from njournal in journalGroup.DefaultIfEmpty()

                              join subjournalname in journal
                              on datas.SubJournalId.ToString() equals subjournalname.Id.ToString()
                              into subjournalGroup
                              from nsubjournal in subjournalGroup.DefaultIfEmpty()

                              select new { datas, ndocumenttypes, njournal, nsubjournal };

            foreach (var item in QSOuterJoin)
                result.Add(new DocumentResponse
                {
                    Id = item.datas.Id,
                    Name = item.datas.Name,
                    DocumentTypeId = item.datas.DocumentTypeId,
                    DocumentTypeName = item.ndocumenttypes.NameTh,
                    Characters = item.datas.Characters,
                    SpecialCharacters = item.datas.SpecialCharacters,
                    Year = item.datas.Year,
                    Month = item.datas.Month,
                    Number = item.datas.Number,
                    JournalId = item.datas.JournalId,
                    JournalName = item.njournal.Name,
                    SubjournalId = item.datas.SubJournalId,
                    SubJournalName = item.nsubjournal.Name,
                    Copies = item.datas.Copies,
                    Active = item.datas.Active,
                });
            return result;
        }


        public List<DocumentResponse> GetDocumentId(int Id)
        {
            var result = new List<DocumentResponse>();
            var data = _databaseACC.Documents.Where(x => x.Id == Id).ToList();
            var DocumentType = _databaseACC.DocumentTypes.ToList();
            var journal = _databaseACC.Journals.ToList();
            var subjournal = _databaseACC.SubJournals.ToList();
            var QSOuterJoin = from datas in data
                              join DocumentTypelname in DocumentType
                              on datas.DocumentTypeId.ToString() equals DocumentTypelname.Id.ToString()
                              into dataDocuments
                              from ndocumenttypes in dataDocuments.DefaultIfEmpty()

                              join journalname in journal
                              on datas.JournalId.ToString() equals journalname.Id.ToString()
                              into journalGroup
                              from njournal in journalGroup.DefaultIfEmpty()

                              join subjournalname in journal
                              on datas.SubJournalId.ToString() equals subjournalname.Id.ToString()
                              into subjournalGroup
                              from nsubjournal in subjournalGroup.DefaultIfEmpty()

                              select new { datas, ndocumenttypes, njournal, nsubjournal };

            foreach (var item in QSOuterJoin)
                result.Add(new DocumentResponse
                {
                    Id = item.datas.Id,
                    Name = item.datas.Name,
                    DocumentTypeId = item.datas.DocumentTypeId,
                    DocumentTypeName = item.ndocumenttypes.NameTh,
                    Characters = item.datas.Characters,
                    SpecialCharacters = item.datas.SpecialCharacters,
                    Year = item.datas.Year,
                    Month = item.datas.Month,
                    Number = item.datas.Number,
                    JournalId = item.datas.JournalId,
                    JournalName = item.njournal.Name,
                    SubjournalId = item.datas.SubJournalId,
                    SubJournalName = item.nsubjournal.Name,
                    Copies = item.datas.Copies,
                    Active = item.datas.Active,
                });
            return result;
        }

        public CommonBaseResponse AddDocument(DocumentRequest request)
        {

            var response = new CommonBaseResponse();
            var Documents = _databaseACC.Documents.Where(x => x.Id == request.Id).FirstOrDefault();
            if (Documents == null)
            {
                var _Documents = new Document();
                _Documents.Name = request.Name;
                _Documents.DocumentTypeId = request.DocumentTypeId;
                _Documents.Characters = request.Characters;
                _Documents.SpecialCharacters = request.SpecialCharacters;
                _Documents.Year = request.Year;
                _Documents.Month = request.Month;
                _Documents.Number = request.Number;
                _Documents.JournalId = request.JournalId;
                _Documents.SubJournalId = request.SubjournalId;
                _Documents.Copies = request.Copies;
                _Documents.Active = request.Active;


                _databaseACC.Entry(_Documents).State = EntityState.Added;
                int returnValue = _databaseACC.SaveChanges();
                response.Success = returnValue > 0 ? true : false;
                response.Messsage = returnValue > 0 ? "Add Complete" : "Add Fail";
            }

      


            else
            {
                response.Success = false;
                response.Messsage = "Error";
            }
            return response;
        }
    
           public CommonBaseResponse EditDocument(DocumentRequest request)
             {
                CommonBaseResponse response = new CommonBaseResponse();
                Document result = _databaseACC.Documents.Where(x => x.Id == request.Id).FirstOrDefault();
                if (result != null)
                {
                    result.Name = request.Name;
                    result.DocumentTypeId = request.DocumentTypeId;
                    result.Characters = request.Characters;
                    result.SpecialCharacters = request.SpecialCharacters;
                    result.Year = request.Year;
                    result.Month = request.Month;
                    result.Number = request.Number;
                    result.JournalId = request.JournalId;
                    result.SubJournalId = request.SubjournalId;
                    result.Copies = request.Copies;
                    result.Active = request.Active;

                    _databaseACC.Entry(result).State = EntityState.Modified;
                    int returnValue = _databaseACC.SaveChanges();
                    response.Success = returnValue > 0 ? true : false;
                    response.Messsage = returnValue > 0 ? "Edit Complete" : "Edit Fail";
                }
                return response;
            }

        public CommonBaseResponse ActiveDocument(int Id , int Active)
        {
            CommonBaseResponse response = new CommonBaseResponse();
            var data = _databaseACC.Documents.Where(x => x.Id == Id).FirstOrDefault();
    if (data != null)
            {
                data.Active = Active;
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
