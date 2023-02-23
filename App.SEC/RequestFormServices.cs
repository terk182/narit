﻿using App.SEC.Requests;
using App.SEC.Responses;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System.Net;
using System.Security.Cryptography;

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

        #region RequestForm
        //----- RequestFormComment -----
        public List<RequestFormCommentStatus> GetRequestFormCommentStatus()
        {
            List<RequestFormCommentStatus> response = _database.RequestFormCommentStatuses.OrderBy(x => x.CodeEnum).ToList();
            return response;
        }
        //----- RequestBudget -----
        public List<RequestBudget> GetRequestBudget()
        {
            List<RequestBudget> response = _database.RequestBudgets.OrderByDescending(x => x.WriteDate).Take(10).ToList();
            return response;
        }
        public RequestBudget GetRequestBudgetById(int id)
        {
            RequestBudget response = _database.RequestBudgets.Where(x => x.Id == id).FirstOrDefault();
            return response;
        }
        public RequestBudget GetRequestBudgetByDocNo (string docNo)
        {
            RequestBudget response = _database.RequestBudgets.Where(x => x.DocNo == docNo).FirstOrDefault();
            return response;
        }
        public SecBaseResponse CreateRequestBudget(RequestBudgetRequests request)
        {
            SecBaseResponse res = new SecBaseResponse();
            RequestBudget response = new RequestBudget();

            if(request.Id == 0)
            {
                response.Active = true;
                response.DocNo = request.DocNo;
                response.DocYear = request.DocYear;
                response.DocStatus = request.DocStatus;
                response.BudgetTypeCode = request.BudgetTypeCode;
                response.Name = request.Name;
                response.Inform = request.Inform;
                response.Descriptions = request.Descriptions;

                response.WriteDate = request.WriteDate;
                response.DateTime = request.DateTime;
                response.CreateDate = DateTime.Now;
                response.CalculationDate = request.CalculationDate;

                response.CreateByStaffId = request.CreateByStaffId;
                response.StatmentName = request.StatmentName;
                response.RelatedRegulation = request.RelatedRegulation;
                response.FilePath = request.FilePath;
                response.DepartmentId = request.DepartmentId;
                response.TotalBudget = request.TotalBudget;

                response.AnotherAction = request.AnotherAction;
                response.Procurement = request.Procurement;
                response.InspectorId = request.InspectorId;
                response.InspectorName = request.InspectorName;
                response.ProcurementByStaff = request.ProcurementByStaff;
                _database.Entry(response).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Save Success";
                    res.data = response;
                    return res;
                }
            }
            else
            {
                RequestBudget findResult = _database.RequestBudgets.Where(x => x.Id == request.Id && x.DocNo == request.DocNo).FirstOrDefault();
                findResult.Active = request.Active;
                findResult.DocNo = request.DocNo;
                findResult.DocYear = request.DocYear;
                findResult.DocStatus = request.DocStatus;
                findResult.BudgetTypeCode = request.BudgetTypeCode;
                findResult.Name = request.Name;
                findResult.Inform = request.Inform;
                findResult.Descriptions = request.Descriptions;
                findResult.WriteDate = request.WriteDate;
                findResult.DateTime = request.DateTime;
                findResult.CreateDate = DateTime.Now;
                findResult.CalculationDate = request.CalculationDate;

                findResult.CreateByStaffId = request.CreateByStaffId;
                findResult.StatmentName = request.StatmentName;
                findResult.RelatedRegulation = request.RelatedRegulation;
                findResult.FilePath = request.FilePath;
                findResult.DepartmentId = request.DepartmentId;
                findResult.TotalBudget = request.TotalBudget;

                findResult.AnotherAction = request.AnotherAction;
                findResult.Procurement = request.Procurement;
                findResult.InspectorId = request.InspectorId;
                findResult.InspectorName = request.InspectorName;
                findResult.ProcurementByStaff = request.ProcurementByStaff;

                _database.Entry(findResult).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Edit Success";
                    res.data = findResult;
                    return res;
                }
            }
            res.Success = false;
            res.Messsage = "Cannot Save and Edit Result.";
            return res;
        }

        public SecBaseResponse EditRequestBudgetById(RequestBudgetRequests request)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestBudget editBudget = new RequestBudget();
            editBudget.Id = request.Id;
            editBudget.DocNo = request.DocNo;
            editBudget.DocStatus = request.DocStatus;
            editBudget.Active= request.Active;
            editBudget.Name = request.Name;
            editBudget.Inform = request.Inform;
            editBudget.Descriptions = request.Descriptions;
            editBudget.WriteDate = request.WriteDate;
            editBudget.DateTime = request.DateTime;
            editBudget.CalculationDate = request.CalculationDate;
            editBudget.StatmentName = request.StatmentName;
            editBudget.RelatedRegulation = request.RelatedRegulation;
            editBudget.FilePath = request.FilePath;
            editBudget.DepartmentId = request.DepartmentId;
            editBudget.TotalBudget = request.TotalBudget;
            _database.Entry(editBudget).State = EntityState.Modified;
            var result = _database.SaveChanges();
            if (result > 0)
            {
                response.Success = true;
                response.Messsage = "Edit Complete";
                response.data = editBudget;
            }
            else
            {
                response.Success = false;
                response.Messsage = "Edit Fail";
            }
            return response;
            //RequestBudget editBudget = new RequestBudget();
            //editBudget.Id = request.Id;
            //editBudget.Active = true;
            //editBudget.DocNo = request.DocNo;
            //editBudget.DocStatus = request.DocStatus;
            //editBudget.Name = request.Name;
            //editBudget.Inform = request.Inform;
            //editBudget.Descriptions = request.Descriptions;
            //editBudget.WriteDate = request.WriteDate;
            //editBudget.DateTime = request.DateTime;
            //editBudget.CalculationDate = request.CalculationDate;
            //editBudget.StatmentName = request.StatmentName;
            //editBudget.RelatedRegulation = request.RelatedRegulation;
            //editBudget.FilePath = request.FilePath;
            //editBudget.DepartmentId = request.DepartmentId;
            //editBudget.TotalBudget = request.TotalBudget;

            //_database.Entry(editBudget).State = EntityState.Modified;
            //var result = _database.SaveChanges();
            //if (result > 0)
            //{
            //    response.Success = true;
            //    response.Messsage = "Edit Complete";
            //}
            //else
            //{
            //    response.Success = false;
            //    response.Messsage = "Edit Fail";
            //}

            //RequestForm requestForm = new RequestForm();
            //requestForm.Id = request.Id;
            //requestForm.Active = true;
            //requestForm.DocNo = request.DocNo;
            //requestForm.RequestBudgetId = request.RequestBudgetId;
            //requestForm.ProjectId = request.ProjectId;
            //requestForm.ProjectActivityId = request.ProjectActivityId;
            //requestForm.Name = request.Name;
            //requestForm.Descriptions = request.Descriptions;
            //requestForm.Objective = request.Objective;
            //requestForm.DepartureDate = request.DepartureDate;
            //requestForm.PracticalDate = request.PracticalDate;
            //requestForm.DateTime = DateTime.Now;
            //requestForm.WorkingInCountry = request.WorkingInCountry;
            //requestForm.Location = request.Location;
            //requestForm.Place = request.Place;
            //requestForm.Country = request.Country;
            //requestForm.Remark = request.Remark;
            //requestForm.PersonRemark = request.PersonRemark;
            //requestForm.MakeBy = request.MakeBy;
            //requestForm.Lecturer = request.Lecturer;
            //requestForm.Reward = request.Reward;

            //_database.Entry(requestForm).State = EntityState.Modified;
            //var result = _database.SaveChanges();
            //if (result > 0)
            //{
            //    response.Success = true;
            //    response.Messsage = "Edit Success";
            //    return response;
            //}
            //else
            //{
            //    response.Success = false;
            //    response.Messsage = "Edit Fail";
            //    return response;
            //}
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
                    response.Messsage = "Delete success";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Delete fail";
                }
            }
            return response;
        }
        //----- RequestBudget -----

        //----- RequestForm -----
        public List<RequestForm> GetRequestForm()
        {
            List<RequestForm> response = new List<RequestForm>();
            return response;
            //List<RequestForm> requestForm = _database.RequestForms.OrderByDescending(x => x.DateTime).ToList();
            //if (requestForm.Count > 0)
            //{
            //    foreach (var form in requestForm)
            //    {
            //        response.Add(new RequestFormResponse
            //        {
            //            Id = form.Id,
            //            DocNo = form.DocNo,
            //            RequestBudgetId = form.RequestBudgetId,
            //            DateTime = form.DateTime,
            //            Active = form.Active,
            //            BudgetTypeId = form.BudgetTypeId,
            //            Country = form.Country,
            //            DepartureDate = form.DepartureDate,
            //            Descriptions = form.Descriptions,
            //            Lecturer = form.Lecturer,
            //            Location = form.Location,
            //            MakeBy = form.MakeBy,
            //            Name = form.Name,
            //            Objective = form.Objective,
            //            PersonRemark = form.PersonRemark,
            //            Place = form.Place,
            //            PracticalDate = form.PracticalDate,
            //            ProjectActivityId = form.ProjectActivityId,
            //            ProjectId = form.ProjectId,
            //            Reward = form.Reward,
            //            SkillType = form.SkillType,
            //            Remark = form.Remark,
            //            WorkingInCountry = form.WorkingInCountry,
            //        });
            //        response.ForEach(rs =>
            //        {

            //            List<FormApproveResponse> respApprove = new List<FormApproveResponse>();
            //            List<FormCommentResponse> respComment = new List<FormCommentResponse>();
            //            List<FormItemsResponse> respItems = new List<FormItemsResponse>();
            //            List<FormBorrowingMoneyResponse> respBorrowingMoney = new List<FormBorrowingMoneyResponse>();
            //            List<FormExaminerForBudgetResponse> respExaminerForBudget = new List<FormExaminerForBudgetResponse>();


            //            var getRequestComment = _database.RequestFormComments.Where(x => x.DocNo == rs.DocNo && x.RequestFormId == rs.Id).ToList();
            //            var getRequestFormItems = _database.RequestFormItems.Where(x => x.DocNo == rs.DocNo && x.RequestFormId == rs.Id).ToList();
            //            var getRequestApprove = _database.RequestFormApproves.Where(x => x.DocNo == rs.DocNo && x.RequestFormId == rs.Id).ToList();
            //            var getBorrowingMoney = _database.RequestFormBorrowingMoneys.Where(x => x.DocNo == rs.DocNo && x.RequestFormId == rs.Id).ToList();
            //            var getExaminerForBudget = _database.RequestFormExaminerForBudgets.Where(x => x.DocNo == rs.DocNo && x.RequestFormId == rs.Id).ToList();

            //            getRequestFormItems.ForEach(item =>
            //            {
            //                respItems.Add(new FormItemsResponse
            //                {
            //                    Id = item.Id,
            //                    RequestFormId = item.RequestFormId,
            //                    DocNo = item.DocNo,
            //                    Name = item.Name,
            //                    Descriptions = item.Descriptions,
            //                    Active = item.Active,
            //                    Price = item.Price,
            //                    Unit = item.Unit,
            //                    TotalBudget = item.TotalBudget,
            //                    Remark = item.Remark,
            //                    LbActivityId = item.LbActivityId
            //                });
            //            });
            //            getRequestApprove.ForEach(app =>
            //            {
            //                if (app.DocNo == rs.DocNo)
            //                {
            //                    respApprove.Add(new FormApproveResponse
            //                    {
            //                        Id = app.Id,
            //                        StaffId = app.StaffId,
            //                        StaffName = app.StaffName,
            //                        StatusApprove = app.StatusApprove,
            //                        DatetimeApprove = app.DatetimeApprove,
            //                        DocNo = app.DocNo,
            //                        DepartmentId = app.DepartmentId,
            //                        JobPositionId = app.JobPositionId,
            //                        RequestFormId = app.RequestFormId,
            //                    });
            //                }
            //            });
            //            getRequestComment.ForEach(comm =>
            //            {
            //                respComment.Add(new FormCommentResponse
            //                {
            //                    Id = comm.Id,
            //                    RequestFormId = comm.RequestFormId,
            //                    DocNo = comm.DocNo,
            //                    DateTime = comm.DateTime,
            //                    StaffId = comm.StaffId,
            //                    StaffName = comm.StaffName,
            //                    Comment = comm.Comment,
            //                    Descriptions = comm.Descriptions,
            //                });
            //            });
            //            getBorrowingMoney.ForEach(bm =>
            //            {
            //                respBorrowingMoney.Add(new FormBorrowingMoneyResponse
            //                {
            //                    Id = bm.Id,
            //                    RequestFormId = bm.RequestFormId,
            //                    DocNo = bm.DocNo,
            //                    DateTime = bm.DateTime,
            //                    StaffId = bm.StaffId,
            //                    StaffName = bm.StaffName,
            //                    RequestLoan = bm.RequestLoan,
            //                });
            //            });
            //            getExaminerForBudget.ForEach(ex =>
            //            {
            //                respExaminerForBudget.Add(new FormExaminerForBudgetResponse
            //                {
            //                    Id = ex.Id,
            //                    RequestFormId = ex.RequestFormId,
            //                    DocNo = ex.DocNo,
            //                    Descriptions = ex.Descriptions,
            //                    Active = ex.Active,
            //                    ExaminerRole = ex.ExaminerRole,
            //                    JobPositionId = ex.JobPositionId,
            //                    DepartmentId = ex.DepartmentId,
            //                    RebudgetId = ex.RebudgetId,
            //                });
            //            });

            //            rs.formItems = respItems;
            //            rs.formApprove = respApprove;
            //            rs.formComment = respComment;
            //            rs.formBorrowingMoney = respBorrowingMoney;
            //            rs.formExaminerForBudgets = respExaminerForBudget;
            //        });
            //    };


            //}
        }
        public List<RequestForm> GetRequestFormByDocNo(string docNo)
        {
            List<RequestForm> response = _database.RequestForms.Where(x => x.DocNo == docNo && x.Active == true).ToList();
            return response;
        }
        public SecBaseResponse CreateRequestFormByDocNo(RequestFormRequests request)
        {
            SecBaseResponse res = new SecBaseResponse();
            RequestForm requestForm = new RequestForm();
            if (request.RequestBudgetId == 0) 
                return res;
            if (request.DocNo == null)
                return res;

            if (request.Id == 0)
            {
                requestForm.Active = true;
                requestForm.DocNo = request.DocNo;
                requestForm.RequestBudgetId = request.RequestBudgetId;
                requestForm.ProjectId = request.ProjectId;
                requestForm.ProjectActivityId = request.ProjectActivityId;
                requestForm.CodeBudgetTypeId = request.CodeBudgetTypeId;
                requestForm.Name = request.Name;
                requestForm.Descriptions = request.Descriptions;
                requestForm.Objective = request.Objective;
                requestForm.StartDepartureDate = request.StartDepartureDate;
                requestForm.EndDepartureDate = request.EndDepartureDate;
                requestForm.StartPracticalDate = request.StartPracticalDate;
                requestForm.EndPracticalDate = request.EndPracticalDate;
                requestForm.WorkingInCountry = request.WorkingInCountry;
                requestForm.Location = request.Location;
                requestForm.Place = request.Place;
                requestForm.Country = request.Country;
                requestForm.Remark = request.Remark;
                requestForm.PersonRemark = request.PersonRemark;
                requestForm.MakeBy = request.MakeBy;
                requestForm.Lecturer = request.Lecturer;
                requestForm.Reward = request.Reward;
                _database.Entry(requestForm).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Create Success";
                    res.data = requestForm;
                    return res;
                }
            }
            else
            {
                RequestForm getResult = _database.RequestForms.Where(x=>x.Id == request.Id 
                && x.RequestBudgetId == request.RequestBudgetId).FirstOrDefault();

                getResult.Active = request.Active;
                getResult.DocNo = request.DocNo;
                getResult.ProjectId = request.ProjectId;
                getResult.ProjectActivityId = request.ProjectActivityId;
                getResult.CodeBudgetTypeId = request.CodeBudgetTypeId;
                getResult.Name = request.Name;
                getResult.Descriptions = request.Descriptions;
                getResult.Objective = request.Objective;
                getResult.StartDepartureDate = request.StartDepartureDate;
                getResult.EndDepartureDate = request.EndDepartureDate;
                getResult.StartPracticalDate = request.StartPracticalDate;
                getResult.EndPracticalDate = request.EndPracticalDate;
                getResult.WorkingInCountry = request.WorkingInCountry;
                getResult.Location = request.Location;
                getResult.Place = request.Place;
                getResult.Country = request.Country;
                getResult.Remark = request.Remark;
                getResult.PersonRemark = request.PersonRemark;
                getResult.MakeBy = request.MakeBy;
                getResult.Lecturer = request.Lecturer;
                getResult.Reward = request.Reward;
                _database.Entry(getResult).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Edit Success";
                    res.data = getResult;
                    return res;
                }
            }
            res.Success = false;
            res.Messsage = "Cannot Save and Edit Result.";
            return res;
        }
        public SecBaseResponse DeleteRequestFormById(int id)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestForm findData = _database.RequestForms.Where(x => x.Id == id).FirstOrDefault();
            if (findData != null)
            {
                findData.Active = false;
                _database.Entry(findData).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Delete success";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Delete fail";
                }
            }



            return response;
        }
        //----- RequestForm -----

        //----- RequestFormItems -----
        public List<RequestFormItem> GetRequestFormItemsByRequestFormId(int requestFormId)
        {
            List<RequestFormItem> response = _database.RequestFormItems.Where(x => x.RequestFormId == requestFormId && x.Active == true).ToList();
            return response;
        }
        public SecBaseResponse CreateRequestFormItemsByRequestFormId(RequestFormItemsRequests request)
        {
            SecBaseResponse res =new SecBaseResponse();
            RequestFormItem response = new RequestFormItem();
            if (request.RequestFormId == 0)
                return res;
            if (request.DocNo == null)
                return res;

            if (request.Id == 0)
            {
                response.Active = true;
                response.DocNo = request.DocNo;
                response.RequestFormId = request.RequestFormId;
                response.Name = request.Name;
                response.Descriptions = request.Descriptions;
                response.Price = request.Price;
                response.TotalBudget = request.TotalBudget;
                response.Unit = request.Unit;
                response.Remark = request.Remark;
                response.LbActivityId = request.LbActivityId;
                _database.Entry(response).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Create Success";
                    res.data = response;
                    return res;
                }
            }
            else
            {
                RequestFormItem getResult = _database.RequestFormItems.Where(x => x.Id == request.Id
                && x.RequestFormId == request.RequestFormId).FirstOrDefault();

                getResult.Active = request.Active;
                getResult.DocNo = request.DocNo;
                getResult.RequestFormId = request.RequestFormId;
                getResult.Name = request.Name;
                getResult.Descriptions = request.Descriptions;
                getResult.Price = request.Price;
                getResult.TotalBudget = request.TotalBudget;
                getResult.Unit = request.Unit;
                getResult.Remark = request.Remark;
                getResult.LbActivityId = request.LbActivityId;
                _database.Entry(getResult).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Edit Success";
                    res.data = getResult;
                    return res;
                }
            }
            res.Success = false;
            res.Messsage = "Cannot Save and Edit Result.";
            return res;
        }
        public SecBaseResponse DeleteRequestFormItemsById(int id)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFormItem findData = _database.RequestFormItems.Where(x => x.Id == id).FirstOrDefault();
            if (findData != null)
            {
                findData.Active = false;
                _database.Entry(findData).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Delete success";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Delete fail";
                }
            }
            return response;
        }
        //----- RequestFormItems -----

        //----- RequestFormApprove -----
        public List<RequestFormApprove> GetRequestFormApproveByRequestFormId(int requestFormId)
        {
            List<RequestFormApprove> response = _database.RequestFormApproves.Where(x => x.RequestFormId == requestFormId && x.Active == true).ToList();
            return response;
        }
        public SecBaseResponse CreateRequestFormApproveByRequestFormId(RequestFormApproveRequests request)
        {
            SecBaseResponse res = new SecBaseResponse();
            RequestFormApprove response = new RequestFormApprove();
            if (request.RequestFormId == 0)
                return res;
            if (request.DocNo == null)
                return res;

            if (request.Id == 0)
            {
                response.DocNo = request.DocNo;
                response.RequestFormId = request.RequestFormId;
                response.JobPositionId = request.JobPositionId;
                response.DepartmentId = request.DepartmentId;
                response.StaffId = request.StaffId;
                response.StaffName = request.StaffName;
                response.StatusApprove = request.StatusApprove;
                response.DatetimeApprove = DateTime.Now;
                _database.Entry(response).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Save Success";
                    res.data = response;
                    return res;
                }
            }
            else
            {
                RequestFormApprove getResult = _database.RequestFormApproves.Where(x => x.Id == request.Id).FirstOrDefault();

                getResult.Active = request.Active;
                getResult.DocNo = request.DocNo;
                getResult.JobPositionId = request.JobPositionId;
                getResult.DepartmentId = request.DepartmentId;
                getResult.StaffId = request.StaffId;
                getResult.StaffName = request.StaffName;
                getResult.StatusApprove = request.StatusApprove;
                getResult.DatetimeApprove = DateTime.Now;
                _database.Entry(getResult).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Edit Success";
                    res.data = getResult;
                    return res;
                }
            }
            res.Success = false;
            res.Messsage = "Cannot Save and Edit Result.";
            return res;
        }
        public SecBaseResponse DeleteRequestFormApproveById(int id)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFormApprove findData = _database.RequestFormApproves.Where(x => x.Id == id).FirstOrDefault();
            if (findData != null)
            {
                findData.Active = false;
                _database.Entry(findData).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Delete success";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Delete fail";
                }
            }
            return response;
        }
        //----- RequestFormApprove -----

        //----- RequestFormComment -----
        public List<RequestFormComment> GetRequestFormCommentByDocNo(string docNo)
        {
            List<RequestFormComment> response = _database.RequestFormComments.Where(x => x.DocNo == docNo && x.Active == true).ToList();
            return response;
        }
        public SecBaseResponse CreateRequestFormCommentByDocNo(RequestFormCommentRequests request)
        {
            SecBaseResponse res = new SecBaseResponse();
            RequestFormComment response = new RequestFormComment();
            if (request.RequestBudgetId == 0)
                return res;
            if (request.DocNo == null)
                return res;

            if (request.Id == 0)
            {
                response.Active = true;
                response.RequestBudgetId = request.RequestBudgetId;
                response.DocNo = request.DocNo;
                response.DateTime = DateTime.Now;
                response.StaffId = request.StaffId;
                response.StaffName = request.StaffName;
                response.Comment = request.Comment;
                response.Descriptions = request.Descriptions;
                response.Status = request.Status;
                _database.Entry(response).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Save Success";
                    res.data = response;
                    return res;
                }
            }
            else
            {
                RequestFormComment getResult = _database.RequestFormComments.Where(x => x.Id == request.Id).FirstOrDefault();

                getResult.Active = getResult.Active;
                getResult.RequestBudgetId = getResult.RequestBudgetId;
                getResult.DocNo = request.DocNo;
                getResult.DateTime = getResult.DateTime;
                getResult.StaffId = request.StaffId;
                getResult.StaffName = request.StaffName;
                getResult.Comment = request.Comment;
                getResult.Descriptions = request.Descriptions;
                response.Status = request.Status;
                _database.Entry(getResult).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = false;
                    res.Messsage = "Edit Success";
                    res.data = getResult;
                    return res;
                }
            }
            res.Success = false;
            res.Messsage = "Cannot Save and Edit Result.";
            return res;
        }
        public SecBaseResponse DeleteRequestFormCommentById(int id)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFormComment findData = _database.RequestFormComments.Where(x => x.Id == id).FirstOrDefault();
            if (findData != null)
            {
                findData.Active = false;
                _database.Entry(findData).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Delete success";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Delete fail";
                }
            }
            return response;
        }
        //----- RequestFormComment -----

        //----- RequestFormBorrowingMoney -----
        public List<RequestFormBorrowingMoney> GetRequestFormBorrowingMoneyByDocNo(string docNo)
        {
            List<RequestFormBorrowingMoney> response = _database.RequestFormBorrowingMoneys.Where(x => x.DocNo == docNo && x.Active == true).ToList();
            return response;
        }
        public SecBaseResponse CreateRequestFormBorrowingMoneyByDocNo(RequestFormBorrowingMoneyRequests request)
        {
            SecBaseResponse res =new SecBaseResponse ();
            RequestFormBorrowingMoney response = new RequestFormBorrowingMoney();
            if (request.RequestBudgetId == 0)
                return res;
            if (request.DocNo == null)
                return res;

            if (request.Id == 0)
            {
                response.Active = true;
                response.RequestBudgetId = request.RequestBudgetId;
                response.DocNo = request.DocNo;
                response.DateTime = DateTime.Now;
                response.StaffId = request.StaffId;
                response.StaffName = request.StaffName;
                response.RequestLoan = request.RequestLoan;
                _database.Entry(response).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Save Success";
                    res.data = response;
                    return res;
                }
            }
            else
            {
                RequestFormBorrowingMoney getResult = _database.RequestFormBorrowingMoneys.Where(x => x.Id == request.Id).FirstOrDefault();

                getResult.Active = request.Active;
                getResult.RequestBudgetId = getResult.RequestBudgetId;
                getResult.DocNo = request.DocNo;
                getResult.DateTime = request.DateTime;
                getResult.StaffId = request.StaffId;
                getResult.StaffName = request.StaffName;
                getResult.RequestLoan = request.RequestLoan;
                _database.Entry(getResult).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Edit Success";
                    res.data = getResult;
                    return res;
                }
            }
            res.Success = false;
            res.Messsage = "Cannot Save and Edit Result.";
            return res;
        }
        public SecBaseResponse DeleteRequestFormBorrowingMoneyById(int id)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFormBorrowingMoney findData = _database.RequestFormBorrowingMoneys.Where(x => x.Id == id).FirstOrDefault();
            if (findData != null)
            {
                findData.Active = false;
                _database.Entry(findData).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Delete success";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Delete fail";
                }
            }
            return response;
        }

        //----- RequestFormBorrowingMoney -----

        //----- RequestFormSchedule -----
        public List<RequestFormSchedule> GetRequestFormScheduleByDocNo(string docNo)
        {
            List<RequestFormSchedule> response = _database.RequestFormSchedules.Where(x => x.DocNo == docNo && x.Active == true).ToList();
            return response;
        }
        public SecBaseResponse CreateRequestFormScheduleByDocNo(RequestFormScheduleRequests request)
        {
            SecBaseResponse res = new SecBaseResponse();

            RequestFormSchedule response = new RequestFormSchedule();
            if (request.RequestBudgetId == 0)
                return res;
            if (request.DocNo == null)
                return res;

            if (request.Id == 0)
            {
                response.RequestBudgetId = request.RequestBudgetId;
                response.DocNo = request.DocNo;
                response.Active = true;
                response.Name = request.Name;
                response.StartDate = request.StartDate;
                response.EndDate = request.EndDate;
                response.StartDateTime = request.StartDateTime;
                response.EndDateTime = request.EndDateTime;
                response.Remark = request.Remark;

                _database.Entry(response).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Save Success";
                    res.data = response;
                    return res;
                }
            }
            else
            {
                RequestFormSchedule getResult = _database.RequestFormSchedules.Where(x => x.Id == request.Id).FirstOrDefault();

                getResult.RequestBudgetId = getResult.RequestBudgetId;
                getResult.DocNo = request.DocNo;
                getResult.Active = request.Active;
                getResult.Name = request.Name;
                getResult.StartDate = request.StartDate;
                getResult.EndDate = request.EndDate;
                getResult.StartDateTime = request.StartDateTime;
                getResult.EndDateTime = request.EndDateTime;
                getResult.Remark = request.Remark;
                _database.Entry(getResult).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Save Success";
                    res.data = response;
                    return res;
                }
            }
            res.Success = false;
            res.Messsage = "Cannot Save and Edit Result.";
            return res;
        }
        public SecBaseResponse DeleteRequestFormScheduleById(int id)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFormSchedule findData = _database.RequestFormSchedules.Where(x => x.Id == id).FirstOrDefault();
            if (findData != null)
            {
                findData.Active = false;
                _database.Entry(findData).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Delete success";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Delete fail";
                }
            }
            return response;
        }

        //----- RequestFormSchedule -----
        public List<RequestFormExaminerForBudget> GetRequestFormExaminerForBudgetByDocNo(string docNo)
        {
            List<RequestFormExaminerForBudget> response = _database.RequestFormExaminerForBudgets.Where(x => x.DocNo == docNo && x.Active == true).ToList();
            return response;
        }
        public SecBaseResponse CreateRequestFormExaminerForBudgetByDocNo(RequestFormExaminerForBudgetRequests request)
        {
            SecBaseResponse res = new SecBaseResponse();

            RequestFormExaminerForBudget response = new RequestFormExaminerForBudget();
            if (request.RequestBudgetId == 0)
                return res;
            if (request.DocNo == null)
                return res;

            if (request.Id == 0)
            {
                response.RequestBudgetId = request.RequestBudgetId;
                response.DocNo = request.DocNo;
                response.Active = true;
                response.Name = request.Name;
                response.Descriptions = request.Descriptions;
                response.ExaminerRole = request.ExaminerRole;
                response.JobPositionId = request.JobPositionId;
                response.DepartmentId = request.DepartmentId;
                response.RebudgetId = request.RebudgetId;
                response.StaffId = request.StaffId;
                response.StaffName = request.StaffName;
                _database.Entry(response).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Save Success";
                    res.data = response;
                    return res;
                }
            }
            else
            {
                RequestFormExaminerForBudget getResult = _database.RequestFormExaminerForBudgets.Where(x => x.Id == request.Id).FirstOrDefault();

                getResult.RequestBudgetId = getResult.RequestBudgetId;
                getResult.DocNo = request.DocNo;
                getResult.Active = request.Active;
                getResult.Name = request.Name;
                getResult.Descriptions = request.Descriptions;
                getResult.ExaminerRole = request.ExaminerRole;
                getResult.JobPositionId = request.JobPositionId;
                getResult.DepartmentId = request.DepartmentId;
                getResult.RebudgetId = request.RebudgetId;
                getResult.StaffId = request.StaffId;
                getResult.StaffName = request.StaffName;
                _database.Entry(getResult).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Edit Success";
                    res.data = response;
                    return res;
                }
            }
            res.Success = false;
            res.Messsage = "Cannot Save and Edit Result.";
            return res;
        }
        public SecBaseResponse DeleteRequestFormExaminerForBudgetById(int id)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFormExaminerForBudget findData = _database.RequestFormExaminerForBudgets.Where(x => x.Id == id).FirstOrDefault();
            if (findData != null)
            {
                findData.Active = false;
                _database.Entry(findData).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    response.Success = true;
                    response.Messsage = "Delete success";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Delete fail";
                }
            }
            return response;
        }
        #endregion

        #region RequestForm_Education
        public SecBaseResponse GetAllRequestBudgetByTypeEducations()
        {
            SecBaseResponse response = new SecBaseResponse();
            List<RequestBudget> getResult = _database.RequestBudgets
                .Where(x=>x.BudgetTypeCode == 50 && x.Active == true)
                .OrderByDescending(x=>x.CreateDate).Take(10).ToList();
            if(getResult.Count() > 0)
            {
                response.Success = true;
                response.Messsage = "Success";
                response.data = getResult;
                return response;
            }
            response.Success = false;
            response.Messsage = "Not Result";
            response.data = null;
            return response;
        }
        public SecBaseResponse GetRequestBudgetByIdTypeEducations(int id)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestBudget getResult = _database.RequestBudgets.Where(x=>x.Id == id && x.Active == true).FirstOrDefault();
            if (getResult != null)
            {
                response.Success = true;
                response.Messsage = "Success";
                response.data = getResult;
                return response;
            }
            response.Success = false;
            response.Messsage = "Not Result";
            response.data = null;
            return response;
        }
        public SecBaseResponse CreateRequestBudgetByTypeEducations(RequestBudgetEduRequests request)
        {
            SecBaseResponse res = new SecBaseResponse();
            RequestBudget resBudget = new RequestBudget();
            RequestForm resForm = new RequestForm();

            if (request.Id == 0)
            {
                resBudget.Active = true;
                resBudget.DocNo = request.DocNo;
                resBudget.DocYear = request.DocYear;

                //--- Fix Code Create By Type Educations ---
                resBudget.DocStatus = "35";
                resBudget.BudgetTypeCode = 50;
                //--- Fix Code Create By Type Educations ---

                resBudget.Name = request.Name;
                resBudget.Inform = request.Inform;
                resBudget.Descriptions = request.Descriptions;

                resBudget.WriteDate = request.WriteDate;
                resBudget.DateTime = request.DateTime;
                resBudget.CreateDate = DateTime.Now;
                resBudget.CalculationDate = request.CalculationDate;

                resBudget.CreateByStaffId = request.CreateByStaffId;
                resBudget.StatmentName = request.StatmentName;
                resBudget.RelatedRegulation = request.RelatedRegulation;
                resBudget.FilePath = request.FilePath;
                resBudget.DepartmentId = request.DepartmentId;
                resBudget.TotalBudget = request.TotalBudget;

                resBudget.AnotherAction = request.AnotherAction;
                resBudget.Procurement = request.Procurement;
                resBudget.InspectorId = request.InspectorId;
                resBudget.InspectorName = request.InspectorName;
                resBudget.ProcurementByStaff = request.ProcurementByStaff;
                _database.Entry(resBudget).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    if(resBudget.Id != 0)
                    {
                        if(request.requestFormEdu.Count > 0)
                        {
                            request.requestFormEdu.ForEach(edu =>
                            {
                                edu.RequestBudgetId = resBudget.Id;
                                edu.DocNo = resBudget.DocNo;
                                var eduForm = CreateRequestFormByTypeEducations(edu);
                                if (eduForm.Success == true)
                                {
                                    res.Success = eduForm.Success;
                                    res.Messsage = "Save Success.";
                                }
                            });
                        }
                    }
                }
            }
            else
            {
                RequestBudget findResult = _database.RequestBudgets.Where(x => x.Id == request.Id && x.DocNo == request.DocNo).FirstOrDefault();
                if (findResult != null)
                {
                    findResult.Active = request.Active;
                    findResult.DocNo = request.DocNo;
                    findResult.DocYear = request.DocYear;
                    findResult.DocStatus = request.DocStatus;
                    findResult.BudgetTypeCode = 50;

                    findResult.Name = request.Name;
                    findResult.Inform = request.Inform;
                    findResult.Descriptions = request.Descriptions;
                    findResult.WriteDate = request.WriteDate;
                    findResult.DateTime = request.DateTime;
                    findResult.CreateDate = DateTime.Now;
                    findResult.CalculationDate = request.CalculationDate;

                    findResult.CreateByStaffId = request.CreateByStaffId;
                    findResult.StatmentName = request.StatmentName;
                    findResult.RelatedRegulation = request.RelatedRegulation;
                    findResult.FilePath = request.FilePath;
                    findResult.DepartmentId = request.DepartmentId;
                    findResult.TotalBudget = request.TotalBudget;

                    findResult.AnotherAction = request.AnotherAction;
                    findResult.Procurement = request.Procurement;
                    findResult.InspectorId = request.InspectorId;
                    findResult.InspectorName = request.InspectorName;
                    findResult.ProcurementByStaff = request.ProcurementByStaff;

                    _database.Entry(findResult).State = EntityState.Modified;
                    var result = _database.SaveChanges();
                    if (result > 0)
                    {
                        if (request.requestFormEdu.Count > 0)
                        {
                            request.requestFormEdu.ForEach(edu =>
                            {
                                edu.RequestBudgetId = resBudget.Id;
                                edu.DocNo = resBudget.DocNo;
                                var eduForm = CreateRequestFormByTypeEducations(edu);
                                if (eduForm.Success == true)
                                {
                                    res.Success = eduForm.Success;
                                    res.Messsage = "Edit Success.";
                                }
                            });
                        }
                        res.data = findResult;
                        res.Success = true;
                        res.Messsage = "Edit Success.";
                    }
                    else {
                        res.data = null;
                        res.Success = false;
                        res.Messsage = "Cannot Save and Edit Result.";
                    }

                }
            }
            return res;
        }
        public SecBaseResponse CreateRequestFormByTypeEducations(RequestFormRequests request)
        {
            SecBaseResponse res = new SecBaseResponse();
            RequestForm resForm = new RequestForm();

            if (request.Id == 0)
            {
                resForm.Active = true;
                resForm.DocNo = request.DocNo;
                resForm.RequestBudgetId = request.RequestBudgetId;
                resForm.ProjectId = request.ProjectId;
                resForm.ProjectActivityId = request.ProjectActivityId;
                resForm.CodeBudgetTypeId = 50;

                resForm.Name = request.Name;
                resForm.Descriptions = request.Descriptions;
                resForm.Objective = request.Objective;
                resForm.StartDepartureDate = request.StartDepartureDate;
                resForm.EndDepartureDate = request.EndDepartureDate;
                resForm.StartPracticalDate = request.StartPracticalDate;
                resForm.EndPracticalDate = request.EndPracticalDate;
                resForm.WorkingInCountry = request.WorkingInCountry;
                resForm.Location = request.Location;
                resForm.Place = request.Place;
                resForm.Country = request.Country;
                resForm.Remark = request.Remark;
                resForm.PersonRemark = request.PersonRemark;
                resForm.MakeBy = request.MakeBy;
                resForm.Lecturer = request.Lecturer;
                resForm.Reward = request.Reward;
                _database.Entry(resForm).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    res.Success = true;
                    res.Messsage = "Save Success.";
                    return res;
                }
                else
                {
                    res.Success = true;
                    res.Messsage = "Save Success.";
                    return res;
                }
            }
            else
            {
                RequestForm getResult = _database.RequestForms.Where(x => x.Id == request.Id
               && x.RequestBudgetId == request.RequestBudgetId).FirstOrDefault();

                if(getResult != null)
                {
                    getResult.Active = request.Active;
                    getResult.DocNo = request.DocNo;
                    getResult.ProjectId = request.ProjectId;
                    getResult.ProjectActivityId = request.ProjectActivityId;
                    getResult.CodeBudgetTypeId = request.CodeBudgetTypeId;
                    getResult.Name = request.Name;
                    getResult.Descriptions = request.Descriptions;
                    getResult.Objective = request.Objective;
                    getResult.StartDepartureDate = request.StartDepartureDate;
                    getResult.EndDepartureDate = request.EndDepartureDate;
                    getResult.StartPracticalDate = request.StartPracticalDate;
                    getResult.EndPracticalDate = request.EndPracticalDate;
                    getResult.WorkingInCountry = request.WorkingInCountry;
                    getResult.Location = request.Location;
                    getResult.Place = request.Place;
                    getResult.Country = request.Country;
                    getResult.Remark = request.Remark;
                    getResult.PersonRemark = request.PersonRemark;
                    getResult.MakeBy = request.MakeBy;
                    getResult.Lecturer = request.Lecturer;
                    getResult.Reward = request.Reward;
                    _database.Entry(getResult).State = EntityState.Modified;
                    var result = _database.SaveChanges();
                    if (result > 0)
                    {
                        res.Success = true;
                        res.Messsage = "Edit Success";
                        res.data = getResult;
                    }
                    else
                    {
                        res.Success = true;
                        res.Messsage = "Edit Success";
                        res.data = null;
                    }
                }
            }
            return res;
        }
        public SecBaseResponse DeleteRequestBudgetByIdTypeEducations(int id)
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
                    response.Messsage = "Delete success";
                }
                else
                {
                    response.Success = false;
                    response.Messsage = "Delete fail";
                }
            }
            return response;
        }
        #endregion


    }
}
