using App.EIS;
using App.Procure.emum;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Procure
{
    public class ProcureServices : IProcureServices
    {
        private readonly NARIT_MIS_LINKContext _database;

        public ProcureServices(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }

        public List<ApproveForm> getApproveFormsbyYear(int year)
        {
            var AllApproveFormList = _database.ApproveForms.Where(c => c.Active && c.FiscalYear == year && c.ProcureTransformStatusEnum != (int)ProcureTransformStatus.FinishTransform).ToList();
            return AllApproveFormList;
        }

        public List<CheckForm> getCheckFormbyYear(int year)
        {
            var AllCheckFormList = _database.CheckForms.Where(c => c.Active && c.FiscalYear == year).ToList();
            return AllCheckFormList;
        }

        public List<OrderForm> getOrderFormbyYear(int year)
        {
            var AllOrderFormList = _database.OrderForms.Where(c => c.Active && c.FiscalYear == year).ToList();
            return AllOrderFormList;
        }

        public List<ProcureLoaningMemoForm> getProcureLoaningMemoFormsbyYear(int year)
        {
            return _database.ProcureLoaningMemoForms.Where(c => c.Active && c.FiscalYear == year && (c.StatementPayStatusEnum == 30 || c.StatementPayStatusEnum == 40)).ToList();
                    
         
        }

        public List<RequestForm> getRequestFormbyYear(int year)
        {
            //var RequestForm = new List<RequestForm>();
            //string sql = String.Format(" SELECT * FROM [Procure].[RequestForms]  WHERE ( [FiscalYear] = '{0}' AND [ProcureApprovalStatusEnum] <> 30)", year);
            //var result = _database.RequestForms.FromSqlRaw(sql);

            //foreach (var item in result)
            //{
            //    RequestForm.Add(item);
            //}
            //return RequestForm;
            var data = _database.RequestForms.Where(c => c.Active && c.FiscalYear == year && c.ProcureApprovalStatusEnum != (int)ProcureApprovalStatus.Denied);
            return data.ToList();
        }
    }
}
