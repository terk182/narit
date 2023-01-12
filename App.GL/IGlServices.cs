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
        // Header 
        List<ChartHeader> GetChartHeader();
        List<ChartHeader> GetChartHeaderId(int id);

        // SubHeader
        List<ChartSubHeader> GetChartSubHeader(int ChartHeaderId);
        List<ChartSubHeader> GetChartSubHeaderId(int id);
        CommonBaseResponse AddSubHeader(ChartRequest request);
        CommonBaseResponse EditSubHeader(EditChartRequest request);
        CommonBaseResponse DelSubHeader(int Id);
        // Major
        List<ChartMajor> GetChartMajor(int ChartSubHeaderId);
        List<ChartMajor> GetChartMajorId(int id);
        CommonBaseResponse AddMajor(ChartRequest request);
        CommonBaseResponse EditMajor(EditChartRequest request);
        CommonBaseResponse DelMajor(int Id);
        //SubMajor
        List<ChartSubMajor> GetChartSubMajor(int ChartMajorId);
        List<ChartSubMajor> GetChartSubMajorId(int id);

        CommonBaseResponse AddSubMajor(ChartRequest request);
        CommonBaseResponse EditSubMajor(EditChartRequest request);
        CommonBaseResponse DelSubMajor(int Id);
        //Minor
        List<ChartMinor> GetChartMinor(int ChartMajorId);
        List<ChartMinor> GetChartMinorId(int id);
        CommonBaseResponse AddMinor(ChartRequest request);
        CommonBaseResponse EditMinor(EditChartRequest request);
        CommonBaseResponse DelMinor(int Id);
        //SubMinor
        List<ChartSubMinor> GetChartSubMinor(int ChartMajorId);
        List<ChartSubMinor> GetChartSubMinorId(int id);
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

    }
}
