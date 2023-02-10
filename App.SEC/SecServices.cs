using App.SEC.Requests;
using App.SEC.Responses;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;

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
            List<RequestFormRequests>? reqForms = new List<RequestFormRequests>();
            List<RequestFormApproveRequest>? reqApprove = new List<RequestFormApproveRequest>();
            List<RequestFormBorrowingMoneyRequest>? reqBM = new List<RequestFormBorrowingMoneyRequest>();
            List<RequestFormCommentRequests>? reqComment = new List<RequestFormCommentRequests>();
            List<RequestFormItemsRequests>? reqItems = new List<RequestFormItemsRequests>();
            List<RequestFormScheduleRequests>? reqSchedule = new List<RequestFormScheduleRequests>();
            List<RequestFormExaminerForBudgetRequests>? reqExam = new List<RequestFormExaminerForBudgetRequests>();


            var findDocNo = _database.RequestBudgets.Where(x => x.DocNo == request.DocNo).ToList();

            if (findDocNo.Count > 0)
            {
                response.Success = false;
                response.Messsage = "DocNo is Duplicate";
            }
            else
            {
                if (request.Id == 0)
                {
                    requestBudget.Active = true;
                    requestBudget.DocNo = request.DocNo;
                    requestBudget.DocStatus = request.DocStatus;
                    requestBudget.Name = request.Name;
                    requestBudget.Inform = request.Inform;
                    requestBudget.Descriptions = request.Descriptions;

                    requestBudget.WriteDate = request.WriteDate;
                    requestBudget.DateTime = request.DateTime;
                    requestBudget.CreateDate = DateTime.Now;
                    requestBudget.CalculationDate = request.CalculationDate;

                    requestBudget.StatmentName = request.StatmentName;
                    requestBudget.RelatedRegulation = request.RelatedRegulation;
                    requestBudget.FilePath = request.FilePath;
                    requestBudget.DepartmentId = request.DepartmentId;
                    requestBudget.TotalBudget = request.TotalBudget;

                    _database.Entry(requestBudget).State = EntityState.Added;
                    var result = _database.SaveChanges();
                    if (result > 0)
                    {
                        var getBudget = _database.RequestBudgets.Where(x => x.DocNo == request.DocNo).FirstOrDefault();
                        if (getBudget.Id != null && getBudget.Id != 0)
                        {
                            request.requestForms.ForEach(form =>
                            {
                                if (form.formApprove.Count > 0)
                                {
                                    form.formApprove.ForEach(addApp =>
                                    {
                                        reqApprove.Add(new RequestFormApproveRequest
                                        {
                                            DocNo = request.DocNo,
                                            RequestFormId = addApp.RequestFormId,
                                            JobPositionId = addApp.JobPositionId,
                                            DepartmentId = addApp.DepartmentId,
                                            StaffId = addApp.StaffId,
                                            StaffName = addApp.StaffName,
                                            StatusApprove = addApp.StatusApprove,
                                            DatetimeApprove = DateTime.Now,
                                        });
                                    });
                                    form.formBorrowingMoney.ForEach(bm =>
                                    {
                                        reqBM.Add(new RequestFormBorrowingMoneyRequest
                                        {
                                            RequestFormId = bm.RequestFormId,
                                            DocNo = request.DocNo,
                                            DateTime = DateTime.Now,
                                            StaffId = bm.StaffId,
                                            StaffName = bm.StaffName,
                                            RequestLoan = bm.RequestLoan
                                        });
                                    });
                                    form.formItems.ForEach(item =>
                                    {
                                        reqItems.Add(new RequestFormItemsRequests
                                        {
                                            Active = true,
                                            DocNo = request.DocNo,
                                            RequestFormId = item.RequestFormId,
                                            Name = item.Name,
                                            Descriptions = item.Descriptions,
                                            Price = item.Price,
                                            TotalBudget = item.TotalBudget,
                                            Unit = item.Unit,
                                            Remark = item.Remark,
                                            LbActivityId = item.LbActivityId,
                                        });
                                    });
                                    form.formComment.ForEach(comm =>
                                    {
                                        reqComment.Add(new RequestFormCommentRequests
                                        {
                                            RequestFormId = comm.RequestFormId,
                                            DocNo = request.DocNo,
                                            StaffId = comm.StaffId,
                                            StaffName = comm.StaffName,
                                            Comment = comm.Comment,
                                            Descriptions = comm.Descriptions,
                                        });
                                    });
                                    form.formSchedules.ForEach(sch =>
                                    {
                                        reqSchedule.Add(new RequestFormScheduleRequests
                                            {
                                            RequestFormId = sch.RequestFormId,
                                            DocNo = request.DocNo,
                                            Active = true,
                                            Name = sch.Name,
                                            RequestLoan = sch.RequestLoan,
                                            StartDate = sch.StartDate,
                                            EndDate = sch.EndDate,
                                            StartDateTime = sch.StartDateTime,
                                            EndDateTime = sch.EndDateTime,
                                        });
                                    });
                                    form.formExaminerForBudgets.ForEach(exam =>
                                    {
                                        reqExam.Add(new RequestFormExaminerForBudgetRequests
                                        {
                                           RequestFormId = exam.RequestFormId,
                                           DocNo = request.DocNo,
                                           Active = true,
                                            Name = exam.Name,
                                            Descriptions = exam.Descriptions,
                                            ExaminerRole = exam.ExaminerRole,
                                            JobPositionId = exam.JobPositionId,
                                            DepartmentId = exam.DepartmentId,
                                            RebudgetId = exam.RebudgetId,
                                        });
                                    });
                                }

                                reqForms.Add(new RequestFormRequests
                                {
                                    Active = true,
                                    DocNo = getBudget.DocNo,
                                    RequestBudgetId = getBudget.Id,
                                    ProjectId = form.ProjectId,
                                    ProjectActivityId = form.ProjectActivityId,
                                    Name = form.Name,
                                    Descriptions = form.Descriptions,
                                    Objective = form.Objective,
                                    DepartureDate = form.DepartureDate,
                                    PracticalDate = form.PracticalDate,
                                    WorkingInCountry = form.WorkingInCountry,
                                    Location = form.Location,
                                    Place = form.Place,
                                    Country = form.Country,
                                    Remark = form.Remark,
                                    PersonRemark = form.PersonRemark,
                                    MakeBy = form.MakeBy,
                                    Lecturer = form.Lecturer,
                                    Reward = form.Reward,
                                });


                            });

                            if (reqForms.Count > 0)
                            {
                                reqForms.ForEach(addForm =>
                                {
                                    var saveForm = CreateRequestFrom(addForm);
                                    var getForms = _database.RequestFroms.Where(x => x.DocNo == request.DocNo).ToList();
                                    if (getForms.Count > 0)
                                    {
                                        getForms.ForEach(gf =>
                                        {

                                            var formID = gf.Id;
                                            reqApprove.ForEach(addApprove =>
                                            {
                                                addApprove.DocNo = request.DocNo;
                                                addApprove.RequestFormId = formID;
                                                var saveApprove = CreateRequestFormApproveByDocNo(addApprove);
                                            });
                                            reqBM.ForEach(bm =>
                                            {
                                                bm.DocNo = request.DocNo;
                                                bm.RequestFormId = formID;
                                                var saveBM = CreateRequestFormBorrowingMoneyByDocNo(bm);
                                            });
                                            reqComment.ForEach(comm =>
                                            {
                                                comm.DocNo = request.DocNo;
                                                comm.RequestFormId = formID;
                                                var saveComm = CreateRequestFromCommentByDocNo(comm);
                                            });
                                            reqItems.ForEach(item =>
                                            {
                                                item.DocNo = request.DocNo;
                                                item.RequestFormId = formID;
                                                var saveComm = CreateRequestFromItemsByDocNo(item);
                                            });
                                            reqSchedule.ForEach(sc =>
                                            {
                                                sc.DocNo = request.DocNo;
                                                sc.RequestFormId = formID;
                                                var saveSc = CreateRequestFormScheduleByDocNo(sc);
                                            });
                                            reqExam.ForEach(ex =>
                                            {
                                                ex.DocNo = request.DocNo;
                                                ex.RequestFormId = formID;
                                                var saveApprove = CreateRequestFormExaminerForBudgetByDocNo(ex);
                                            });
                                        });
                                    }
                                });

                            }
                        }
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
                        findData.DocNo = findData.DocNo;
                        findData.DocStatus = request.DocStatus;
                        findData.Name = request.Name;
                        findData.Inform = request.Inform;
                        findData.Descriptions = request.Descriptions;
                        findData.WriteDate = request.WriteDate;
                        findData.DateTime = request.DateTime;
                        findData.CreateDate = DateTime.Now;
                        findData.CalculationDate = request.CalculationDate;
                        findData.StatmentName = request.StatmentName;
                        findData.RelatedRegulation = request.RelatedRegulation;
                        findData.FilePath = request.FilePath;
                        findData.DepartmentId = findData.DepartmentId;
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
                        DocNo = form.DocNo,
                        RequestBudgetId = form.RequestBudgetId,
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
                        PracticalDate = form.PracticalDate,
                        ProjectActivityId = form.ProjectActivityId,
                        ProjectId = form.ProjectId,
                        Reward = form.Reward,
                        SkillType = form.SkillType,
                        Remark = form.Remark,
                        WorkingInCountry = form.WorkingInCountry,
                    });
                    response.ForEach(rs =>
                    {

                        List<FormApproveResponse> respApprove = new List<FormApproveResponse>();
                        List<FormCommentResponse> respComment = new List<FormCommentResponse>();
                        List<FormItemsResponse> respItems = new List<FormItemsResponse>();
                        List<FormBorrowingMoneyResponse> respBorrowingMoney = new List<FormBorrowingMoneyResponse>();
                        List<FormExaminerForBudgetResponse> respExaminerForBudget = new List<FormExaminerForBudgetResponse>();


                        var getRequestComment = _database.RequestFormComments.Where(x => x.DocNo == rs.DocNo && x.RequestFormId == rs.Id).ToList();
                        var getRequestFormItems = _database.RequestFormItems.Where(x => x.DocNo == rs.DocNo && x.RequestFormId == rs.Id).ToList();
                        var getRequestApprove = _database.RequestFormApproves.Where(x => x.DocNo == rs.DocNo && x.RequestFormId == rs.Id).ToList();
                        var getBorrowingMoney = _database.RequestFormBorrowingMoneys.Where(x => x.DocNo == rs.DocNo && x.RequestFormId == rs.Id).ToList();
                        var getExaminerForBudget = _database.RequestFormExaminerForBudgets.Where(x => x.DocNo == rs.DocNo && x.RequestFormId == rs.Id).ToList();

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
                                Unit = item.Unit,
                                TotalBudget = item.TotalBudget,
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
                                    StaffId = app.StaffId,
                                    StaffName = app.StaffName,
                                    StatusApprove = app.StatusApprove,
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
                                DateTime = comm.DateTime,
                                StaffId = comm.StaffId,
                                StaffName = comm.StaffName,
                                Comment = comm.Comment,
                                Descriptions = comm.Descriptions,
                            });
                        });
                        getBorrowingMoney.ForEach(bm =>
                        {
                            respBorrowingMoney.Add(new FormBorrowingMoneyResponse
                            {
                                Id = bm.Id,
                                RequestFormId = bm.RequestFormId,
                                DocNo = bm.DocNo,
                                DateTime = bm.DateTime,
                                StaffId = bm.StaffId,
                                StaffName = bm.StaffName,
                                RequestLoan = bm.RequestLoan,
                            });
                        });
                        getExaminerForBudget.ForEach(ex =>
                        {
                            respExaminerForBudget.Add(new FormExaminerForBudgetResponse
                            {
                                Id = ex.Id,
                                RequestFormId = ex.RequestFormId,
                                DocNo = ex.DocNo,
                                Descriptions = ex.Descriptions,
                                Active = ex.Active,
                                ExaminerRole = ex.ExaminerRole,
                                JobPositionId = ex.JobPositionId,
                                DepartmentId = ex.DepartmentId,
                                RebudgetId = ex.RebudgetId,
                            });
                        });

                        rs.formItems = respItems;
                        rs.formApprove = respApprove;
                        rs.formComment = respComment;
                        rs.formBorrowingMoney = respBorrowingMoney;
                        rs.formExaminerForBudgets = respExaminerForBudget;
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
        public RequestFormRequests CreateRequestFrom(RequestFormRequests request)
        {
            RequestFormRequests response = new RequestFormRequests();
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
                requestFrom.PracticalDate = request.PracticalDate;
                requestFrom.DateTime = DateTime.Now;
                requestFrom.WorkingInCountry = request.WorkingInCountry;
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
                    RequestFrom data = _database.RequestFroms.Where(x => x.DocNo == request.DocNo && x.RequestBudgetId == request.RequestBudgetId).FirstOrDefault();
                    return response;
                }
                else
                {
                    return response;
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
                    findData.PracticalDate = request.PracticalDate;
                    findData.WorkingInCountry = request.WorkingInCountry;
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
                        RequestFrom data = _database.RequestFroms.Where(x => x.DocNo == request.DocNo && x.RequestBudgetId == request.RequestBudgetId).FirstOrDefault();
                        return response;
                    }
                    else
                    {
                        return response;
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
                requestFromItem.TotalBudget = request.TotalBudget;
                requestFromItem.Unit = request.Unit;
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
                    findData.TotalBudget = request.TotalBudget;
                    findData.Unit = request.Unit;
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
                formApprove.JobPositionId = request.JobPositionId;
                formApprove.DepartmentId = request.DepartmentId;
                formApprove.StaffId = request.StaffId;
                formApprove.StaffName = request.StaffName;
                formApprove.StatusApprove = request.StatusApprove;
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
                    formApprove.DocNo = request.DocNo;
                    formApprove.RequestFormId = request.RequestFormId;
                    formApprove.JobPositionId = request.JobPositionId;
                    formApprove.DepartmentId = request.DepartmentId;
                    formApprove.StaffId = request.StaffId;
                    formApprove.StaffName = request.StaffName;
                    formApprove.StatusApprove = request.StatusApprove;
                    formApprove.DatetimeApprove = DateTime.Now;
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
        public SecBaseResponse CreateRequestFromCommentByDocNo(RequestFormCommentRequests request)
        {
            SecBaseResponse response = new SecBaseResponse();
            RequestFormComment formComm = new RequestFormComment();
            if (request.Id == 0)
            {
                formComm.RequestFormId = request.RequestFormId;
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
                if (findData.Count > 0)
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
                schedule.RequestFormId = request.RequestFormId;
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
                res.RequestFormId = request.RequestFormId;
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

