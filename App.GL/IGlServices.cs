using App.Common.Models.Responses;
using App.GL.Requests;
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
        // SubHeader
        List<ChartSubHeader> GetChartSubHeader(int ChartHeaderId);
        CommonBaseResponse AddSubHeader(ChartRequest request);
        CommonBaseResponse EditSubHeader(EditChartRequest request);
        CommonBaseResponse DelSubHeader(int Id);
        // Major
        List<ChartMajor> GetChartMajor(int ChartSubHeaderId);
        CommonBaseResponse AddMajor(ChartRequest request);
        CommonBaseResponse EditMajor(EditChartRequest request);
        CommonBaseResponse DelMajor(int Id);
        //SubMajor
        List<ChartSubMajor> GetChartSubMajor(int ChartMajorId);
        CommonBaseResponse AddSubMajor(ChartRequest request);
        CommonBaseResponse EditSubMajor(EditChartRequest request);
        CommonBaseResponse DelSubMajor(int Id);
        //Minor
        List<ChartMinor> GetChartMinor(int ChartMajorId);
        CommonBaseResponse AddMinor(ChartRequest request);
        CommonBaseResponse EditMinor(EditChartRequest request);
        CommonBaseResponse DelMinor(int Id);
        //SubMinor
        List<ChartSubMinor> GetChartSubMinor(int ChartMajorId);
        CommonBaseResponse AddSubMinor(SubMinorRequest request);
        CommonBaseResponse EditSubMinor(EditSubMinorRequest request);
        CommonBaseResponse DelSubMinor(int Id);

        //AccountType
        CommonBaseResponse AddAccountType(CreateAccountTypeRequest request);
        CommonBaseResponse EditAccountType(CreateAccountTypeRequest request);
        CommonBaseResponse DeleteAccountTypeId(int Id);
        List<AccountType> GetAccountType();
        AccountType GetAccountTypeId(int Id);

        //AccountReceivableType
        List<AccountReceivableType> GetAccountReceivableType();
        AccountReceivableType GetAccountReceivableTypeId(int id);
        CommonBaseResponse AddAccountReceivableType(AccountReceivableTypeRequest request);
        CommonBaseResponse EditAccountReceivableType(AccountReceivableTypeRequest request);
        CommonBaseResponse DeleteAccountReceivableTypeId(int Id);

        //AccountPayableType
        List<AccountPayableType> GetAccountPayableType();
        AccountPayableType GetAccountPayableTypeId(int id);
        CommonBaseResponse AddAccountPayableType(AccountPayableTypeRequest request);
        CommonBaseResponse EditAccountPayableType(AccountPayableTypeRequest request);
        CommonBaseResponse DeletetAccountPayableTypeId(int Id);

    }
}
