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

        List<RequestBudget> GetRequestBudget();
        RequestBudget GetRequestBudgetById(int id);
        RequestBudget CreateRequestBudget(RequestBudgetRequests request);
        SecBaseResponse EditRequestBudgetById(RequestBudgetRequests request);

        SecBaseResponse DeleteRequestBudgetById(int id);

        List<RequestFormResponse> GetRequestForm();
        RequestForm GetRequestFormByDocNo(string docNo);
        RequestForm CreateRequestFormByDocNo(RequestFormRequests request);
        SecBaseResponse DeleteRequestFormById(int id);

        List<RequestFormItem> GetRequestFormItemsByDocNo(string docNo);
        RequestFormItem CreateRequestFormItemsByDocNo(RequestFormItemsRequests request);
        SecBaseResponse DeleteRequestFormItemsById(string docNo);

        List<RequestFormApprove> GetRequestFormApproveByDocNo(string docNo);
        RequestFormApprove CreateRequestFormApproveByDocNo(RequestFormApproveRequests request);
        SecBaseResponse DeleteRequestFormApproveByDocNo(string docNo);

        List<RequestFormComment> GetRequestFormCommentByDocNo(string docNo);
        RequestFormComment CreateRequestFormCommentByDocNo(RequestFormCommentRequests request);

        List<RequestFormBorrowingMoney> GetRequestFormBorrowingMoneyByDocNo(string docNo);
        RequestFormBorrowingMoney CreateRequestFormBorrowingMoneyByDocNo(RequestFormBorrowingMoneyRequests request);

        List<RequestFormSchedule> GetRequestFormScheduleByDocNo(string docNo);
        RequestFormSchedule CreateRequestFormScheduleByDocNo(RequestFormScheduleRequests request);

        List<RequestFormExaminerForBudget> GetRequestFormExaminerForBudgetByDocNo(string docNo);
        RequestFormExaminerForBudget CreateRequestFormExaminerForBudgetByDocNo(RequestFormExaminerForBudgetRequests request);
    }
}
