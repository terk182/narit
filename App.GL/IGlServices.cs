using App.Common.Models.Responses;
using App.GL.DTO;
using App.GL.Requests;
using App.GL.Responses;
using narit_acc_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.GL
{
    public interface IGlServices
    {
        List<ChartHeader> GetChartAll();

        // Header 
        List<ChartResponse> GetChartHeader();
        List<ChartResponse> GetChartHeaderId(int Id);

        // SubHeader
        List<ChartResponse> GetChartSubHeader(int ChartHeaderId);
        List<ChartResponse> GetChartSubHeaderId(int Id);
        CommonBaseResponse AddSubHeader(ChartRequest request);
        CommonBaseResponse EditSubHeader(EditChartRequest request);
        CommonBaseResponse DelSubHeader(int Id);
        // Major
        List<ChartResponse> GetChartMajor(int ChartSubHeaderId);
        List<ChartResponse> GetChartMajorId(int Id);
        CommonBaseResponse AddMajor(ChartRequest request);
        CommonBaseResponse EditMajor(EditChartRequest request);
        CommonBaseResponse DelMajor(int Id);
        //SubMajor
        List<ChartResponse> GetChartSubMajor(int ChartMajorId);
        List<ChartResponse> GetChartSubMajorId(int Id);
        CommonBaseResponse AddSubMajor(ChartRequest request);
        CommonBaseResponse EditSubMajor(EditChartRequest request);
        CommonBaseResponse DelSubMajor(int Id);
        //Minor
        List<ChartMinor> GetAllChartMinor();
        List<ChartResponse> GetChartMinor(int ChartMajorId);
        List<ChartResponse> GetChartMinorId(int Id);
        CommonBaseResponse AddMinor(ChartRequest request);
        CommonBaseResponse EditMinor(EditChartRequest request);
        CommonBaseResponse DelMinor(int Id);
        //SubMinor
        //List<ChartSubMinor> GetAllChartSubMinor();
        //List<ChartResponse> GetChartSubMinor(int ChartMajorId);
        //List<ChartResponse> GetChartSubMinorId(int id);
        //CommonBaseResponse AddSubMinor(SubMinorRequest request);
        //CommonBaseResponse EditSubMinor(EditSubMinorRequest request);
        //CommonBaseResponse DelSubMinor(int Id);

        //AccountType
        CommonBaseResponse AddAccountType(CreateAccountTypeRequest request);
        CommonBaseResponse EditAccountType(CreateAccountTypeRequest request);
        CommonBaseResponse DeleteAccountTypeId(int Id);
        List<AccountType> GetAccountType();
        AccountType GetAccountTypeId(int Id);

        //DebtorType
        List<DebtorType> GetDebtorType();
        DebtorType GetDebtorTypeId(int Id);
        CommonBaseResponse AddDebtorType(DebtorTypeRequest request);
        CommonBaseResponse EditDebtorType(DebtorTypeRequest request);
        CommonBaseResponse DeleteDebtorTypeId(int Id);

        List<DebtorCreditorResponse> GetAllDebtor();

        //CreditorType
        List<CreditorType> GetCreditorType();
        CreditorType GetCreditorTypeId(int Id);
        CommonBaseResponse AddCreditorType(CreditorTypeRequest request);
        CommonBaseResponse EditCreditorType(CreditorTypeRequest request);
        CommonBaseResponse DeletetCreditorTypeId(int Id);

        //Creditor
        List<Creditor> GetCreditor();
        Creditor GetCreditorId(int Id);
        CommonBaseResponse AddCreditor(CreditorRequest request);
        CommonBaseResponse EditCreditor(CreditorRequest request);
        CommonBaseResponse DeleteCreditorId(int Id);

        //Transection
        List<TransectionResponse> GetTransection();
        List<TransectionResponse> GetTransectionId(int Id);

        CommonBaseResponse EditTransection(EditTransectionRequest request);

        //Journal
        List<Journal> GetJournal();
        List<Journal> GetJournalID(int Id);

        List<SubJournal> GetSubJournal(int JournalID);
        List<SubJournalDto> GetSubJournalID(int Id);
        CommonBaseResponse AddSubJournal(SubJournalResponse request);
        CommonBaseResponse EditSubJournal(SubJournalDto request);

        // Report
        List<Accounting> ReportGlAll();

        ////List<Accounting> reportchart(DateTime? DetailDate, int? MinorID);
        ReportChartResponse reportchartdate(ReportChartRequest request);
        ReportChartResponse PostReportGlDate(ReportChartRequest request);
        //Document
        List<DocumentType> GetDocumentType();

        List<DocumentResponse> GetDocument(int Active);
        List<DocumentResponse> GetDocumentId(int Id);
        CommonBaseResponse AddDocument(DocumentRequest request);
        CommonBaseResponse EditDocument(DocumentRequest request);
        CommonBaseResponse ActiveDocument(int Id , int Active);



    }
}
