using App.Common.Models.Responses;
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
        List<ChartResponse> GetChartHeaderId(int id);

        // SubHeader
        List<ChartResponse> GetChartSubHeader(int ChartHeaderId);
        List<ChartResponse> GetChartSubHeaderId(int id);
        CommonBaseResponse AddSubHeader(ChartRequest request);
        CommonBaseResponse EditSubHeader(EditChartRequest request);
        CommonBaseResponse DelSubHeader(int Id);
        // Major
        List<ChartResponse> GetChartMajor(int ChartSubHeaderId);
        List<ChartResponse> GetChartMajorId(int id);
        CommonBaseResponse AddMajor(ChartRequest request);
        CommonBaseResponse EditMajor(EditChartRequest request);
        CommonBaseResponse DelMajor(int Id);
        //SubMajor
        List<ChartResponse> GetChartSubMajor(int ChartMajorId);
        List<ChartResponse> GetChartSubMajorId(int id);
        CommonBaseResponse AddSubMajor(ChartRequest request);
        CommonBaseResponse EditSubMajor(EditChartRequest request);
        CommonBaseResponse DelSubMajor(int Id);
        //Minor
        List<ChartResponse> GetChartMinor(int ChartMajorId);
        List<ChartResponse> GetChartMinorId(int id);
        CommonBaseResponse AddMinor(ChartRequest request);
        CommonBaseResponse EditMinor(EditChartRequest request);
        CommonBaseResponse DelMinor(int Id);
        //SubMinor
        List<ChartResponse> GetChartSubMinor(int ChartMajorId);
        List<ChartResponse> GetChartSubMinorId(int id);
        CommonBaseResponse AddSubMinor(SubMinorRequest request);
        CommonBaseResponse EditSubMinor(EditSubMinorRequest request);
        CommonBaseResponse DelSubMinor(int Id);

        //AccountType
        CommonBaseResponse AddAccountType(CreateAccountTypeRequest request);
        CommonBaseResponse EditAccountType(CreateAccountTypeRequest request);
        CommonBaseResponse DeleteAccountTypeId(int Id);
        List<AccountType> GetAccountType();
        AccountType GetAccountTypeId(int Id);

        //DebtorType
        List<DebtorType> GetDebtorType();
        DebtorType GetDebtorTypeId(int id);
        CommonBaseResponse AddDebtorType(DebtorTypeRequest request);
        CommonBaseResponse EditDebtorType(DebtorTypeRequest request);
        CommonBaseResponse DeleteDebtorTypeId(int Id);

        //CreditorType
        List<CreditorType> GetCreditorType();
        CreditorType GetCreditorTypeId(int id);
        CommonBaseResponse AddCreditorType(CreditorTypeRequest request);
        CommonBaseResponse EditCreditorType(CreditorTypeRequest request);
        CommonBaseResponse DeletetCreditorTypeId(int Id);

        //Creditor
        List<Creditor> GetCreditor();
        Creditor GetCreditorId(int id);
        CommonBaseResponse AddCreditor(CreditorRequest request);
        CommonBaseResponse EditCreditor(CreditorRequest request);
        CommonBaseResponse DeleteCreditorId(int Id);


    }
}
