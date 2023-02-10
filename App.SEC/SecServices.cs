using App.Common.Dtos;
using App.Common.Helper;
using App.SEC.Dtos;
using App.SEC.enums;
using App.SEC.helper;
using App.SEC.Models;
using App.SEC.Models.Requests;
using App.SEC.Models.Responses;
using App.SEC.Requests;
using App.SEC.Responses;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using narit_mis_api.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Numerics;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Data.SqlClient.Server;

namespace App.SEC
{
    public class SecServices : ISecServices
    {
        private readonly CGI_MISContext _database;

        public SecServices(CGI_MISContext context)
        {
            _database = context;
        }

        public List<ScheduleFisicalYear> GetScheduleFisicalYear()
        {
            List<ScheduleFisicalYear> response = _database.ScheduleFisicalYears.ToList();
            return response;
        }
        public List<ScheduleFisicalYear> GetScheduleFisicalYearByYears(int name, bool active)
        {
            List<ScheduleFisicalYear> schedules = _database.ScheduleFisicalYears.Where(x => x.Name == name && x.Active == active).ToList();
            return schedules;
        }

        public List<RequestBudget> GetRequestBudget()
        {
            List<RequestBudget> response = _database.RequestBudgets.OrderByDescending(x => x.WriteDate).Take(20).ToList();
            return response;
        }
        public RequestBudget GetRequestBudgetById(int id)
        {
            RequestBudget response = _database.RequestBudgets.Where(x => x.Id == id).FirstOrDefault();
            return response;
        }
        public SecBaseResponse CreateRequestBudget(RequestBudgetRequests request)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestBudget requestBudget = new RequestBudget();
            if (request.Id == 0)
            {
                requestBudget.Active = true;
                requestBudget.Name = request.Name;
                requestBudget.Inform = request.Inform;
                requestBudget.Descriptions = request.Descriptions;
                requestBudget.WriteDate = request.WriteDate;
                requestBudget.CalculationDate = request.CalculationDate;
                requestBudget.StatmentName = request.StatmentName;
                requestBudget.RelatedRegulation = request.RelatedRegulation;
                requestBudget.CreateDate = DateTime.Now;
                requestBudget.FilePath = request.FilePath;
                requestBudget.DepartmentId = request.DepartmentId;
                requestBudget.TotalBudget = request.TotalBudget;
                _database.Entry(requestBudget).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Add complete";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Fail";
                }
            }
            else
            {
                RequestBudget findData = _database.RequestBudgets.Where(x => x.Id == request.Id).FirstOrDefault();
                if (findData != null)
                {
                    findData.Name = request.Name;
                    findData.Inform = request.Inform;
                    findData.Descriptions = request.Descriptions;
                    findData.WriteDate = request.WriteDate;
                    findData.CalculationDate = request.CalculationDate;
                    findData.StatmentName = request.StatmentName;
                    findData.RelatedRegulation = request.RelatedRegulation;
                    findData.CreateDate = DateTime.Now;
                    findData.FilePath = request.FilePath;
                    findData.DepartmentId = request.DepartmentId;
                    findData.TotalBudget = request.TotalBudget;
                    _database.Entry(findData).State = EntityState.Modified;
                    var result = _database.SaveChanges();
                    if (result > 0)
                    {
                        response.Success = true;
                        response.Messsage = "Add complete";
                    }
                    else
                    {
                        response.Success = false;
                        response.Messsage = "Fail";
                    }
                }

            }

            return response;
        }
        public SecBaseResponse DeleteRequestBudgetById(int id)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestBudget findData = _database.RequestBudgets.Where(x => x.Id == id).FirstOrDefault();
            if (findData != null)
            {
                findData.Active = false;
                _database.Entry(findData).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Edit complete";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Fail";
                }
            }



            return response;
        }

        public List<RequestFormResponse> GetRequestFrom()
        {
            List<RequestFormResponse> response = new List<RequestFormResponse>();



            List<RequestFrom> requestFrom = _database.RequestFroms.OrderByDescending(x => x.DateTime).ToList();
            if (requestFrom.Count > 0)
            {
                foreach (var form in requestFrom)
                {
                    response.Add(new RequestFormResponse
                    {
                        Id = form.Id,
                        RequestBudgetId = form.RequestBudgetId,
                        DocNo = form.DocNo,
                        DateTime = form.DateTime,
                        Active = form.Active,
                        BudgetTypeId = form.BudgetTypeId,
                        Country = form.Country,
                        DepartureDate = form.DepartureDate,
                        Descriptions = form.Descriptions,
                        Lecturer = form.Lecturer,
                        Location = form.Location,
                        MakeBy = form.MakeBy,
                        Name = form.Name,
                        Objective = form.Objective,
                        PersonRemark = form.PersonRemark,
                        Place = form.Place,
                        PracticalDay = form.PracticalDay,
                        ProjectActivityId = form.ProjectActivityId,
                        ProjectId = form.ProjectId,
                        Remark = form.Remark,
                    });
                    response.ForEach(rs =>
                    {

                        List<FormApproveResponse> respApprove = new List<FormApproveResponse>();
                        List<FormCommentResponse> respComment = new List<FormCommentResponse>();
                        List<FormItemsResponse> respItems = new List<FormItemsResponse>();
                        var getRequestComment = _database.RequestFormComments.Where(x => x.DocNo == rs.DocNo && x.RequestFormId == rs.Id).ToList();
                        var getRequestFormItems = _database.RequestFormItems.Where(x => x.DocNo == rs.DocNo && x.RequestFormId == rs.Id).ToList();
                        var getRequestApprove = _database.RequestFormApproves.Where(x => x.DocNo == rs.DocNo && x.RequestFormId == rs.Id).ToList();
                        getRequestFormItems.ForEach(item =>
                        {
                            respItems.Add(new FormItemsResponse
                            {
                                Id = item.Id,
                                RequestFormId = item.RequestFormId,
                                DocNo = item.DocNo,
                                Name = item.Name,
                                Descriptions = item.Descriptions,
                                Active = item.Active,
                                Price = item.Price,
                                TotalPrice = item.TotalPrice,
                                Unit = item.Unit,
                                TotalUnit = item.Unit,
                                Remark = item.Remark,
                                LbActivityId = item.LbActivityId
                            });
                        });
                        getRequestApprove.ForEach(app =>
                        {
                            if (app.DocNo == rs.DocNo)
                            {
                                respApprove.Add(new FormApproveResponse
                                {
                                    Id = app.Id,
                                    Name = app.Name,
                                    DatetimeApprove = app.DatetimeApprove,
                                    DocNo = app.DocNo,
                                    DepartmentId = app.DepartmentId,
                                    JobPositionId = app.JobPositionId,
                                    RequestFormId = app.RequestFormId,
                                });
                            }
                        });
                        getRequestComment.ForEach(comm =>
                        {
                            respComment.Add(new FormCommentResponse
                            {
                                Id = comm.Id,
                                RequestFormId = comm.RequestFormId,
                                DocNo = comm.DocNo,
                                DateTime = DateTime.Now,
                                StaffId = comm.StaffId,
                                StaffName = comm.StaffName,
                                Comment = comm.Comment,
                                Descriptions = comm.Descriptions,
                            });
                        });

                        rs.formItems = respItems;
                        rs.formApprove = respApprove;
                        rs.formComment = respComment;
                    });
                };


            }
            return response;
        }
        public RequestFrom GetRequestFromByDocNo(string docNo)
        {
            RequestFrom response = _database.RequestFroms.Where(x => x.DocNo == docNo).FirstOrDefault();
            return response;
        }
        public SecBaseResponse CreateRequestFrom(RequestFormRequests request)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFrom requestFrom = new RequestFrom();
            if (request.Id == 0)
            {
                requestFrom.Active = true;
                requestFrom.DocNo = request.DocNo;
                requestFrom.RequestBudgetId = request.RequestBudgetId;
                requestFrom.ProjectId = request.ProjectId;
                requestFrom.ProjectActivityId = request.ProjectActivityId;
                requestFrom.Name = request.Name;
                requestFrom.Descriptions = request.Descriptions;
                requestFrom.Objective = request.Objective;
                requestFrom.DepartureDate = request.DepartureDate;
                requestFrom.PracticalDay = request.PracticalDay;
                requestFrom.DateTime = DateTime.Now;
                requestFrom.WorkingIncountry = request.WorkingIncountry;
                requestFrom.Location = request.Location;
                requestFrom.Place = request.Place;
                requestFrom.Country = request.Country;
                requestFrom.Remark = request.Remark;
                requestFrom.PersonRemark = request.PersonRemark;
                requestFrom.MakeBy = request.MakeBy;
                requestFrom.Lecturer = request.Lecturer;
                requestFrom.Reward = request.Reward;
                _database.Entry(requestFrom).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Add complete";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Fail";
                }
            }
            else
            {
                RequestFrom findData = _database.RequestFroms.Where(x => x.DocNo == request.DocNo).FirstOrDefault();
                if (findData != null)
                {
                    findData.DocNo = request.DocNo;
                    findData.RequestBudgetId = request.RequestBudgetId;
                    findData.ProjectId = request.ProjectId;
                    findData.ProjectActivityId = request.ProjectActivityId;
                    findData.Name = request.Name;
                    findData.Descriptions = request.Descriptions;
                    findData.Objective = request.Objective;
                    findData.DepartureDate = request.DepartureDate;
                    findData.PracticalDay = request.PracticalDay;
                    findData.WorkingIncountry = request.WorkingIncountry;
                    findData.Location = request.Location;
                    findData.Place = request.Place;
                    findData.Country = request.Country;
                    findData.Remark = request.Remark;
                    findData.PersonRemark = request.PersonRemark;
                    findData.MakeBy = request.MakeBy;
                    findData.Lecturer = request.Lecturer;
                    findData.Reward = request.Reward;
                    _database.Entry(requestFrom).State = EntityState.Modified;
                    var result = _database.SaveChanges();
                    if (result > 0)
                    {
                        response.Success = true;
                        response.Messsage = "Edit complete";
                    }
                    else
                    {
                        response.Success = false;
                        response.Messsage = "Fail";
                    }
                }

            }

            return response;
        }
        public SecBaseResponse DeleteRequestFromById(int id)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFrom findData = _database.RequestFroms.Where(x => x.Id == id).FirstOrDefault();
            if (findData != null)
            {
                findData.Active = false;
                _database.Entry(findData).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Edit complete";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Fail";
                }
            }



            return response;
        }

        public List<RequestFormItem> GetRequestFromItemsByDocNo(string docNo)
        {
            List<RequestFormItem> response = _database.RequestFormItems.Where(x => x.DocNo == docNo).ToList();
            return response;
        }
        public SecBaseResponse CreateRequestFromItemsByDocNo(RequestFormItemsRequests request)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFormItem requestFromItem = new RequestFormItem();
            if (request.DocNo == null)
            {
                response.Success = false;
                response.Messsage = "DocNo Is Null";
            }
            if (request.Id == 0)
            {
                requestFromItem.Active = true;
                requestFromItem.DocNo = request.DocNo;
                requestFromItem.RequestFormId = request.RequestFormId;
                requestFromItem.Name = request.Name;
                requestFromItem.Descriptions = request.Descriptions;
                requestFromItem.Price = request.Price;
                requestFromItem.TotalPrice = request.TotalPrice;
                requestFromItem.Unit = request.TotalUnit;
                requestFromItem.Remark = request.Remark;
                requestFromItem.LbActivityId = request.LbActivityId;
                _database.Entry(requestFromItem).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Add complete";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Fail";
                }
            }
            else
            {
                RequestFormItem findData = _database.RequestFormItems.Where(x => x.DocNo == request.DocNo && x.Id == request.Id).FirstOrDefault();
                if (findData != null)
                {
                    findData.DocNo = findData.DocNo;
                    findData.RequestFormId = findData.RequestFormId;
                    findData.Name = request.Name;
                    findData.Descriptions = request.Descriptions;
                    findData.Price = request.Price;
                    findData.TotalPrice = request.TotalPrice;
                    findData.Unit = request.TotalUnit;
                    findData.Remark = request.Remark;
                    findData.LbActivityId = request.LbActivityId;
                    _database.Entry(findData).State = EntityState.Modified;
                    var result = _database.SaveChanges();
                    if (result > 0)
                    {
                        response.Success = true;
                        response.Messsage = "Edit complete";
                    }
                    else
                    {
                        response.Success = false;
                        response.Messsage = "Fail";
                    }
                }
            }

            return response;
        }
        public SecBaseResponse DeleteRequestFromItemsById(string docNo)
        {
            SecBaseResponse response = new SecBaseResponse();
            List<RequestFormItem> findData = _database.RequestFormItems.Where(x => x.DocNo == docNo).ToList();
            if (findData.Count > 0)
            {
                findData.ForEach(item =>
                {
                    item.Active = false;
                    _database.Entry(item).State = EntityState.Modified;
                    var result = _database.SaveChanges();
                    if (result > 0)
                    {
                        response.Success = true;
                        response.Messsage = "Edit complete";
                    }
                    else
                    {
                        response.Success = false;
                        response.Messsage = "Fail";
                    }
                });
            }
            return response;
        }

        public List<RequestFormApprove> GetRequestFormApproveByDocNo(string docNo)
        {
            List<RequestFormApprove> response = _database.RequestFormApproves.Where(x => x.DocNo == docNo).ToList();
            return response;
        }
        public SecBaseResponse CreateRequestFormApproveByDocNo(RequestFormApproveRequest request)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFormApprove formApprove = new RequestFormApprove();
            if (request.Id == 0)
            {
                formApprove.DocNo = request.DocNo;
                formApprove.RequestFormId = request.RequestFormId;
                formApprove.Name = request.Name;
                formApprove.JobPositionId = request.JobPositionId;
                formApprove.DepartmentId = request.DepartmentId;
                formApprove.DatetimeApprove = DateTime.Now;
                _database.Entry(formApprove).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Add complete";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Fail";
                }
            }
            else
            {
                RequestFormApprove findData = _database.RequestFormApproves.Where(x => x.DocNo == request.DocNo).FirstOrDefault();
                if (findData != null)
                {
                    formApprove.DocNo = findData.DocNo;
                    formApprove.RequestFormId = findData.RequestFormId;
                    formApprove.Name = request.Name;
                    formApprove.JobPositionId = request.JobPositionId;
                    formApprove.DepartmentId = request.DepartmentId;
                    _database.Entry(formApprove).State = EntityState.Modified;
                    var result = _database.SaveChanges();
                    if (result > 0)
                    {
                        response.Success = true;
                        response.Messsage = "Edit complete";
                    }
                    else
                    {
                        response.Success = false;
                        response.Messsage = "Fail";
                    }
                }

            }

            return response;
        }
        public SecBaseResponse DeleteRequestFormApproveByDocNo(string docNo)
        {
            SecBaseResponse response = new SecBaseResponse();
            List<RequestFormApprove> findData = _database.RequestFormApproves.Where(x => x.DocNo == docNo).ToList();
            if (findData.Count > 0)
            {
                findData.ForEach(item =>
                {
                    _database.Entry(item).State = EntityState.Deleted;
                    var result = _database.SaveChanges();
                    if (result > 0)
                    {
                        response.Success = true;
                        response.Messsage = "Delete complete";
                    }
                    else
                    {
                        response.Success = false;
                        response.Messsage = "Fail";
                    }
                });
            }
            return response;
        }

        public List<RequestFormComment> GetRequestCommentByDocNo(string docNo)
        {
            List<RequestFormComment> response = _database.RequestFormComments.Where(x => x.DocNo == docNo).ToList();
            return response;
        }
        public SecBaseResponse CreateRequestFormCommentByDocNo(RequestFormCommentRequests request)
        {
            SecBaseResponse response  = new SecBaseResponse();
            RequestFormComment formComm = new RequestFormComment();
            if(request.Id == 0)
            {
                formComm.RequestFormId= request.Id;
                formComm.DocNo = request.DocNo;
                formComm.DateTime = DateTime.Now;
                formComm.StaffId = request.StaffId;
                formComm.StaffName = request.StaffName;
                formComm.Comment = request.Comment;
                formComm.Descriptions = request.Descriptions;
                _database.Entry(formComm).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Add complete";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Fail";
                }
            }
            else
            {
                List<RequestFormComment> findData = _database.RequestFormComments.Where(x => x.DocNo == request.DocNo).ToList();
                if(findData.Count > 0)
                {
                    findData.ForEach(x =>
                    {
                        x.RequestFormId = x.Id;
                        x.DocNo = x.DocNo;
                        x.StaffId = request.StaffId;
                        x.StaffName = request.StaffName;
                        x.Comment = request.Comment;
                        x.Descriptions = request.Descriptions;
                        _database.Entry(x).State = EntityState.Modified;
                        var result = _database.SaveChanges();
                        if (result > 0)
                        {
                            response.Success = true;
                            response.Messsage = "Edit complete";
                        }
                        else
                        {
                            response.Success = false;
                            response.Messsage = "Fail";
                        }
                    });
                }
            }

            return response;
        }

        public List<RequestFormBorrowingMoney> GetRequestFormBorrowingMoneyByDocNo(string docNo)
        {
            List<RequestFormBorrowingMoney> response = _database.RequestFormBorrowingMoneys.Where(x => x.DocNo == docNo).ToList();
            return response;
        }
        public SecBaseResponse CreateRequestFormBorrowingMoneyByDocNo(RequestFormBorrowingMoneyRequest request)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFormBorrowingMoney formBm = new RequestFormBorrowingMoney();
            if (request.Id == 0)
            {
                formBm.RequestFormId = request.Id;
                formBm.DocNo = request.DocNo;
                formBm.DateTime = DateTime.Now;
                formBm.StaffId = request.StaffId;
                formBm.StaffName = request.StaffName;
                formBm.RequestLoan = request.RequestLoan;
                _database.Entry(formBm).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Add complete";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Fail";
                }
            }
            else
            {
                List<RequestFormBorrowingMoney> findData = _database.RequestFormBorrowingMoneys.Where(x => x.DocNo == request.DocNo).ToList();
                if (findData.Count > 0)
                {
                    findData.ForEach(x =>
                    {
                        x.RequestFormId = x.Id;
                        x.DocNo = x.DocNo;
                        x.StaffId = request.StaffId;
                        x.StaffName = request.StaffName;
                        x.RequestLoan = request.RequestLoan;
                        _database.Entry(x).State = EntityState.Modified;
                        var result = _database.SaveChanges();
                        if (result > 0)
                        {
                            response.Success = true;
                            response.Messsage = "Edit complete";
                        }
                        else
                        {
                            response.Success = false;
                            response.Messsage = "Fail";
                        }
                    });
                }
            }

            return response;
        }


        public List<RequestFormSchedule> GetRequestFormScheduleByDocNo(string docNo)
        {
            List<RequestFormSchedule> response = _database.RequestFormSchedules.Where(x => x.DocNo == docNo).ToList();
            return response;
        }
        public SecBaseResponse CreateRequestFormScheduleByDocNo(RequestFormScheduleRequests request)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFormSchedule schedule = new RequestFormSchedule();
            if (request.Id == 0)
            {
                schedule.RequestFormId = request.Id;
                schedule.DocNo = request.DocNo;
                schedule.Active = true;
                schedule.Name = request.Name;
                schedule.RequestLoan = request.RequestLoan;
                schedule.StartDate = request.StartDate;
                schedule.EndDate = request.EndDate;
                schedule.StartDateTime = request.StartDateTime;
                schedule.EndDateTime = request.EndDateTime;
                _database.Entry(schedule).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Add complete";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Fail";
                }
            }
            else
            {
                List<RequestFormSchedule> findData = _database.RequestFormSchedules.Where(x => x.DocNo == request.DocNo).ToList();
                if (findData.Count > 0)
                {
                    findData.ForEach(x =>
                    {
                        schedule.RequestFormId = x.Id;
                        schedule.DocNo = x.DocNo;
                        schedule.Name = request.Name;
                        schedule.RequestLoan = request.RequestLoan;
                        schedule.StartDate = request.StartDate;
                        schedule.EndDate = request.EndDate;
                        schedule.StartDateTime = request.StartDateTime;
                        schedule.EndDateTime = request.EndDateTime;
                        _database.Entry(x).State = EntityState.Modified;
                        var result = _database.SaveChanges();
                        if (result > 0)
                        {
                            response.Success = true;
                            response.Messsage = "Edit complete";
                        }
                        else
                        {
                            response.Success = false;
                            response.Messsage = "Fail";
                        }
                    });
                }
            }

            return response;
        }

        public List<RequestFormExaminerForBudget> GetRequestFormExaminerForBudgetByDocNo(string docNo)
        {
            List<RequestFormExaminerForBudget> response = _database.RequestFormExaminerForBudgets.Where(x => x.DocNo == docNo).ToList();
            return response;
        }
        public SecBaseResponse CreateRequestFormExaminerForBudgetByDocNo(RequestFormExaminerForBudgetRequests request)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFormExaminerForBudget res = new RequestFormExaminerForBudget();
            if (request.Id == 0)
            {
                res.RequestFormId = request.Id;
                res.DocNo = request.DocNo;
                res.Active = true;
                res.Name = request.Name;
                res.Descriptions = request.Descriptions;
                res.ExaminerRole = request.ExaminerRole;
                res.JobPositionId = request.JobPositionId;
                res.DepartmentId = request.DepartmentId;
                res.RebudgetId = request.RebudgetId;
                _database.Entry(res).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Add complete";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Fail";
                }
            }
            else
            {
                List<RequestFormExaminerForBudget> findData = _database.RequestFormExaminerForBudgets.Where(x => x.DocNo == request.DocNo).ToList();
                if (findData.Count > 0)
                {
                    findData.ForEach(x =>
                    {
                        x.RequestFormId = request.Id;
                        x.DocNo = request.DocNo;
                        x.Active = true;
                        x.Name = request.Name;
                        x.Descriptions = request.Descriptions;
                        x.ExaminerRole = request.ExaminerRole;
                        x.JobPositionId = request.JobPositionId;
                        x.DepartmentId = request.DepartmentId;
                        x.RebudgetId = request.RebudgetId;
                        _database.Entry(x).State = EntityState.Modified;
                        var result = _database.SaveChanges();
                        if (result > 0)
                        {
                            response.Success = true;
                            response.Messsage = "Edit complete";
                        }
                        else
                        {
                            response.Success = false;
                            response.Messsage = "Fail";
                        }
                    });
                }
            }

            return response;
        }

      
    }
}

