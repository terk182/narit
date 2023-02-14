using App.NewCGIMIS.Responses;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.NewCGIMIS
{
    public class NewCGIMISServices : INewCGIMISServices
    {
        private readonly NARIT_MIS_LINKContext _database;
        public NewCGIMISServices(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }
        ///////////////////////new new new by ardin/////////////////////////////
        //MainGovtStatement
        public List<MainGovtStatement> GetAllMainGovtStatement()
        {
            return _database.MainGovtStatements.Where(x => x.Active).ToList();
        }
        public List<MainGovtStatement> GetMainGovtStatementbyFisicalYear(int FisicalYear)
        {
            var data = _database.MainGovtStatements.Where(x => x.FiscalYear == FisicalYear && x.Active).ToList();
            return data;
        }
        public List<MainGovtStatement> GetMainGovtStatementbyId(int MainGovtStatementId)
        {
            var data = _database.MainGovtStatements.Where(x => x.Id == MainGovtStatementId && x.Active).ToList();
            return data;
        }
        public NewBaseResponse MainGovtStatementSetup(MainGovtStatement request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new NewBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }
        public NewBaseResponse DeleteMainGovtStatement(int MainGovtStatementId)
        {
            var response = new NewBaseResponse();
            var data = _database.MainGovtStatements.Where(x => x.Id == MainGovtStatementId).FirstOrDefault();
            if (data != null)
            {
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delete Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
    }
}
