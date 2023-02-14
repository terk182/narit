using App.SEC.Requests;
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

        //----- RequestBudget -----
        public List<RequestBudget> GetRequestBudget()
        {
            List<RequestBudget> response = _database.RequestBudgets.OrderByDescending(x => x.WriteDate).Take(10).ToList();
            return response;
        }
        public RequestBudget GetRequestBudgetByDocNo (string docNo)
        {
            RequestBudget response = _database.RequestBudgets.Where(x => x.DocNo == docNo).FirstOrDefault();
            return response;
        }
        public RequestBudget CreateRequestBudget(RequestBudgetRequests request)
        {
            RequestBudget response = new RequestBudget();
            RequestBudget findResult = _database.RequestBudgets.Where(x => x.DocNo == request.DocNo).FirstOrDefault();
            if(findResult == null)
            {
                response.Active = true;
                response.DocNo = request.DocNo;
                response.DocStatus = request.DocStatus;
                response.Name = request.Name;
                response.Inform = request.Inform;
                response.Descriptions = request.Descriptions;

                response.WriteDate = request.WriteDate;
                response.DateTime = request.DateTime;
                response.CreateDate = DateTime.Now;
                response.CalculationDate = request.CalculationDate;

                response.StatmentName = request.StatmentName;
                response.RelatedRegulation = request.RelatedRegulation;
                response.FilePath = request.FilePath;
                response.DepartmentId = request.DepartmentId;
                response.TotalBudget = request.TotalBudget;

                response.AnotherAction = request.AnotherAction;
                response.Procurement = request.Procurement;
                response.InspectorId = request.InspectorId;
                response.InspectorName = request.InspectorName;

                _database.Entry(response).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    return response;
                }
            }

            if (findResult.Id != 0 && findResult.Id != null)
            {
                findResult.Active = request.Active;
                findResult.DocNo = request.DocNo;
                findResult.DocStatus = request.DocStatus;
                findResult.Name = request.Name;
                findResult.Inform = request.Inform;
                findResult.Descriptions = request.Descriptions;
                findResult.WriteDate = request.WriteDate;
                findResult.DateTime = request.DateTime;
                findResult.CreateDate = DateTime.Now;
                findResult.CalculationDate = request.CalculationDate;
                findResult.StatmentName = request.StatmentName;
                findResult.RelatedRegulation = request.RelatedRegulation;
                findResult.FilePath = request.FilePath;
                findResult.DepartmentId = request.DepartmentId;
                findResult.TotalBudget = request.TotalBudget;

                response.AnotherAction = request.AnotherAction;
                response.Procurement = request.Procurement;
                response.InspectorId = request.InspectorId;
                response.InspectorName = request.InspectorName;

                _database.Entry(findResult).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    return response;
                }
            }
            return response;
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
        public SecBaseResponse DeleteRequestBudgetByDocNo(string docNo)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestBudget findData = _database.RequestBudgets.Where(x => x.DocNo == docNo).FirstOrDefault();
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
        public RequestForm CreateRequestFormByDocNo(RequestFormRequests request)
        {
            RequestForm requestForm = new RequestForm();
            if (request.RequestBudgetId == 0) 
                return requestForm;
            if (request.DocNo == null)
                return requestForm;

            if (request.Id == 0)
            {
                requestForm.Active = true;
                requestForm.DocNo = request.DocNo;
                requestForm.RequestBudgetId = request.RequestBudgetId;
                requestForm.ProjectId = request.ProjectId;
                requestForm.ProjectActivityId = request.ProjectActivityId;
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
                    return requestForm;
                }
            }
            else
            {
                RequestForm getResult = _database.RequestForms.Where(x=>x.Id== request.Id 
                && x.RequestBudgetId == request.RequestBudgetId).FirstOrDefault();

                getResult.Active = request.Active;
                getResult.DocNo = request.DocNo;
                getResult.ProjectId = request.ProjectId;
                getResult.ProjectActivityId = request.ProjectActivityId;
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
                    return getResult;
                }

            }
            return requestForm;
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
        public List<RequestFormItem> GetRequestFormItemsByDocNo(string docNo)
        {
            List<RequestFormItem> response = _database.RequestFormItems.Where(x => x.DocNo == docNo && x.Active == true).ToList();
            return response;
        }
        public RequestFormItem CreateRequestFormItemsByDocNo(RequestFormItemsRequests request)
        {
            RequestFormItem response = new RequestFormItem();
            if (request.RequestBudgetId == 0)
                return response;
            if (request.DocNo == null)
                return response;

            if (request.Id == 0)
            {
                response.Active = true;
                response.DocNo = request.DocNo;
                response.RequestBudgetId = request.RequestBudgetId;
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
                    return response;
                }
            }
            else
            {
                RequestFormItem getResult = _database.RequestFormItems.Where(x => x.Id == request.Id
                && x.RequestBudgetId == request.RequestBudgetId).FirstOrDefault();

                getResult.Active = request.Active;
                getResult.DocNo = request.DocNo;
                getResult.RequestBudgetId = request.RequestBudgetId;
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
                    return getResult;
                }

            }
            return response;
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
        public List<RequestFormApprove> GetRequestFormApproveByDocNo(string docNo)
        {
            List<RequestFormApprove> response = _database.RequestFormApproves.Where(x => x.DocNo == docNo && x.Active == true).ToList();
            return response;
        }
        public RequestFormApprove CreateRequestFormApproveByDocNo(RequestFormApproveRequests request)
        {
            RequestFormApprove response = new RequestFormApprove();
            if (request.RequestBudgetId == 0)
                return response;
            if (request.DocNo == null)
                return response;

            if (request.Id == 0)
            {
                response.DocNo = request.DocNo;
                response.RequestBudgetId = request.RequestBudgetId;
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
                    return response;
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
                    return getResult;
                }

            }
            return response;
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
        public RequestFormComment CreateRequestFormCommentByDocNo(RequestFormCommentRequests request)
        {
            RequestFormComment response = new RequestFormComment();
            if (request.RequestBudgetId == 0)
                return response;
            if (request.DocNo == null)
                return response;

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
                _database.Entry(response).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    return response;
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
                _database.Entry(getResult).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    return getResult;
                }

            }
            return response;
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
        public RequestFormBorrowingMoney CreateRequestFormBorrowingMoneyByDocNo(RequestFormBorrowingMoneyRequests request)
        {
            RequestFormBorrowingMoney response = new RequestFormBorrowingMoney();
            if (request.RequestBudgetId == 0)
                return response;
            if (request.DocNo == null)
                return response;

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
                    return response;
                }
            }
            else
            {
                RequestFormBorrowingMoney getResult = _database.RequestFormBorrowingMoneys.Where(x => x.Id == request.Id).FirstOrDefault();

                getResult.Active = request.Active;
                getResult.DocNo = request.DocNo;
                getResult.DateTime = getResult.DateTime;
                getResult.StaffId = request.StaffId;
                getResult.StaffName = request.StaffName;
                getResult.RequestLoan = request.RequestLoan;
                _database.Entry(getResult).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    return getResult;
                }

            }
            return response;

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
        public RequestFormSchedule CreateRequestFormScheduleByDocNo(RequestFormScheduleRequests request)
        {
            RequestFormSchedule response = new RequestFormSchedule();
            if (request.RequestBudgetId == 0)
                return response;
            if (request.DocNo == null)
                return response;

            if (request.Id == 0)
            {
                response.RequestBudgetId = request.RequestBudgetId;
                response.DocNo = request.DocNo;
                response.Active = true;
                response.Name = request.Name;
                response.RequestLoan = request.RequestLoan;
                response.StartDate = request.StartDate;
                response.EndDate = request.EndDate;
                response.StartDateTime = request.StartDateTime;
                response.EndDateTime = request.EndDateTime;
                _database.Entry(response).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    return response;
                }
            }
            else
            {
                RequestFormSchedule getResult = _database.RequestFormSchedules.Where(x => x.Id == request.Id).FirstOrDefault();

                getResult.RequestBudgetId = getResult.RequestBudgetId;
                getResult.DocNo = request.DocNo;
                getResult.Active = request.Active;
                getResult.Name = request.Name;
                getResult.RequestLoan = request.RequestLoan;
                getResult.StartDate = request.StartDate;
                getResult.EndDate = request.EndDate;
                getResult.StartDateTime = request.StartDateTime;
                getResult.EndDateTime = request.EndDateTime;
                _database.Entry(getResult).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    return getResult;
                }
            }
            return response;
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
        public RequestFormExaminerForBudget CreateRequestFormExaminerForBudgetByDocNo(RequestFormExaminerForBudgetRequests request)
        {
            RequestFormExaminerForBudget response = new RequestFormExaminerForBudget();
            if (request.RequestBudgetId == 0)
                return response;
            if (request.DocNo == null)
                return response;

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
                _database.Entry(response).State = EntityState.Added;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    return response;
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
                _database.Entry(getResult).State = EntityState.Modified;
                var result = _database.SaveChanges();
                if (result > 0)
                {
                    return getResult;
                }
            }
            return response;

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

    }
}

