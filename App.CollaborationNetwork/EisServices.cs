using App.EIS.Models;
using App.EIS.Dtos;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using App.EIS.Models.Responses;
using App.EIS.Models.Requests;
using App.Common;
using App.SEC;
using App.SEC.Dtos;

namespace App.EIS
{
    public class EisServices : IEisServices
    {
        private readonly CGI_MISContext _database;
        private readonly  ICommonServices _CommonServices;
        private readonly ISecServices _SecServices;
        public EisServices(CGI_MISContext context, ICommonServices CommonServices, ISecServices secServices)
        {
            _database = context;
            _CommonServices = CommonServices;
            _SecServices = secServices;
        }

       
    }
}
