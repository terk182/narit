using narit_mis_api.Models;
using App.FIN.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.FIN.Models.Responses;
using App.FIN.Models.Requests;
using App.SEC.Models.Responses;

namespace App.FIN
{
    public interface IFinServices
    {
        List<RegisterProcureItemTypeDto> getAllRegis();
        //RegisterProcureItemType getById(int id);
        List<SupplierDto> getAllSupplier();

        List<SupplierDto> getSupplierbyName(string name);

        List<ProcureStoreLocationDto> getAllStoreLocation();

        FinBaseResponse ProcureItemTypeSetup(ProcureItemTypeRequest request);

        FinBaseResponse SupplierDetailSetup(SupplierRequest request);

        FinBaseResponse ProcureStoreLocationSetup(ProcureStoreLocationRequest request);

        DocumentFormResponse DocumentForm(DocumentFormRequest request);

        ViewRequestFormListResponses ViewRequestFormListForFinancialApproval(ViewRequestFormListRequest request);

        List<RegisterProcureItem> RegisterProcureItemSearch(int checkBox, int fiscalYear, int departmentId);

        List<RegisterProcureItem> ShowRegisterProcureItemListByDepartment(int checkBox, int fiscalYear, int departmentId);

        RequestApproveOrderCheckformDto SearchProcureDocForTrackingRoute(int document, string documentNumber, int fiscalYear);
        List<CheckForm> ViewRequestFormList(ViewRequestFormListMainRequest request);
        PlanFormFinancialStatusReportRespone PlanFormFinancialStatusReport(PlanFormFinancialStatusReportRequest request);

        List<ViewFormForApprovalByFinanceResponses> ViewFormForApprovalByFinance(ViewFormForApprovalByFinanceRequest request);
        List<ViewFormForApprovalByHeadOfFinanceResponse> ViewFormForApprovalByHeadOfFinance(ViewFormForApprovalByHeadOfFinanceRequest request);
        List<ViewProcureLoaningMemoFormListForApprovalResponses> ViewProcureLoaningMemoFormListForApproval(ViewProcureLoaningMemoFormListForApprovalRequest request);
        List<ViewProcureReimbursementMemoFormListForApprovalResponses> ViewProcureReimbursementMemoFormListForApproval(ViewProcureReimbursementMemoFormListForApprovalRequest request);
        List<ViewProcureSettleReceiptFormListForApprovalResponses> ViewProcureSettleReceiptFormListForApproval(ViewProcureSettleReceiptFormListForApprovalRequest request);
        List<ViewProcureSettleMemoFormListForApprovalResponses> ViewProcureSettleMemoFormListForApproval(ViewProcureSettleMemoFormListForApprovalRequest request);
        FinancialReserveStatementYearEndBriefReportByBudgetTypeRequest FinancialReserveStatementYearEndBriefReportByBudgetType();
        FinancialReserveStatementYearEndReportByBudgetTypeRequest FinancialReserveStatementYearEndReportByBudgetType();
        FinancialReserveStatementYearEndReportByPlanTypeRequest FinancialReserveStatementYearEndReportByPlanType();
        FinancialReserveStatementMonthlyBriefReportByBudgetTypeRequest FinancialReserveStatementMonthlyBriefReportByBudgetType();
        FinancialReserveStatementMonthlyReportByBudgetTypeRequest FinancialReserveStatementMonthlyReportByBudgetType();
    }
}
