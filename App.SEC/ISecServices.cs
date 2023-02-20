using App.Common.Dtos;
using App.SEC.Dtos;
using App.SEC.Models;
using App.SEC.Models.Requests;
using App.SEC.Models.Responses;
using App.SEC.Requests;
using App.SEC.Responses;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC
{
    public interface ISecServices
    {
        List<ScheduleFisicalYear> GetScheduleFisicalYear();
        List<ScheduleFisicalYear> GetScheduleFisicalYearByYears(int name, bool active);

        List<RequestFormCommentStatus> GetRequestFormCommentStatus();
        List<RequestBudget> GetRequestBudget();
        RequestBudget GetRequestBudgetById(int id);
        RequestBudget GetRequestBudgetByDocNo(string docNo);
        SecBaseResponse CreateRequestBudget(RequestBudgetRequests request);
        SecBaseResponse EditRequestBudgetById(RequestBudgetRequests request);
        SecBaseResponse DeleteRequestBudgetById(int id);

        //List<RequestForm> GetRequestForm();
        List<RequestForm> GetRequestFormByDocNo(string docNo);
        SecBaseResponse CreateRequestFormByDocNo(RequestFormRequests request);
        SecBaseResponse DeleteRequestFormById(int id);

        List<RequestFormItem> GetRequestFormItemsByRequestFormId(int requestFormId);
        SecBaseResponse CreateRequestFormItemsByRequestFormId(RequestFormItemsRequests request);
        SecBaseResponse DeleteRequestFormItemsById(int id);

        List<RequestFormApprove> GetRequestFormApproveByRequestFormId(int requestFormId);
        SecBaseResponse CreateRequestFormApproveByRequestFormId(RequestFormApproveRequests request);
        SecBaseResponse DeleteRequestFormApproveById(int id);

        List<RequestFormComment> GetRequestFormCommentByDocNo(string docNo);
        SecBaseResponse CreateRequestFormCommentByDocNo(RequestFormCommentRequests request);
        SecBaseResponse DeleteRequestFormCommentById(int id);


        List<RequestFormBorrowingMoney> GetRequestFormBorrowingMoneyByDocNo(string docNo);
        SecBaseResponse CreateRequestFormBorrowingMoneyByDocNo(RequestFormBorrowingMoneyRequests request);
        SecBaseResponse DeleteRequestFormBorrowingMoneyById(int id);


        List<RequestFormSchedule> GetRequestFormScheduleByDocNo(string docNo);
        SecBaseResponse CreateRequestFormScheduleByDocNo(RequestFormScheduleRequests request);
        SecBaseResponse DeleteRequestFormScheduleById(int id);


        List<RequestFormExaminerForBudget> GetRequestFormExaminerForBudgetByDocNo(string docNo);
        SecBaseResponse CreateRequestFormExaminerForBudgetByDocNo(RequestFormExaminerForBudgetRequests request);
        SecBaseResponse DeleteRequestFormExaminerForBudgetById(int id);

    }
}
