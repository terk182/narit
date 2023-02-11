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
        SecBaseResponse CreateRequestBudget(RequestBudgetRequests request);
        SecBaseResponse DeleteRequestBudgetById(int id);

        List<RequestFormResponse> GetRequestFrom();
        RequestFrom GetRequestFromByDocNo(string docNo);
        RequestFrom CreateRequestFrom(RequestFormRequests request);
        SecBaseResponse EditRequestBudgetById(RequestBudgetRequests request);

        SecBaseResponse DeleteRequestFromById(int id);

        List<RequestFormItem> GetRequestFromItemsByDocNo(string docNo);
        SecBaseResponse CreateRequestFromItemsByDocNo(RequestFormItemsRequests request);
        SecBaseResponse DeleteRequestFromItemsById(string docNo);

        List<RequestFormApprove> GetRequestFormApproveByDocNo(string docNo);
        SecBaseResponse CreateRequestFormApproveByDocNo(RequestFormApproveRequest request);
        SecBaseResponse DeleteRequestFormApproveByDocNo(string docNo);

        SecBaseResponse CreateRequestFromCommentByDocNo(RequestFormCommentRequests request);
        List<RequestFormComment> GetRequestCommentByDocNo(string docNo);

        List<RequestFormBorrowingMoney> GetRequestFormBorrowingMoneyByDocNo(string docNo);
        SecBaseResponse CreateRequestFormBorrowingMoneyByDocNo(RequestFormBorrowingMoneyRequest request);

        List<RequestFormSchedule> GetRequestFormScheduleByDocNo(string docNo);
        SecBaseResponse CreateRequestFormScheduleByDocNo(RequestFormScheduleRequests request);

        List<RequestFormExaminerForBudget> GetRequestFormExaminerForBudgetByDocNo(string docNo);
        SecBaseResponse CreateRequestFormExaminerForBudgetByDocNo(RequestFormExaminerForBudgetRequests request);
    }
}
