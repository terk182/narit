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
        private readonly CGI_MISContext _database;

        public ProcureServices(CGI_MISContext context)
        {
            _database = context;
        }

          }
}
