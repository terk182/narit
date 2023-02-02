using App.EIS;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Plan
{
    public class PlanServices : IPlanServices
    {
        private readonly CGI_MISContext _database;

        public PlanServices(CGI_MISContext context)
        {
            _database = context;
        }



    }
}
