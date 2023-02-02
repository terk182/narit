using narit_mis_api.Models;
using App.FIN.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.FIN.Models.Responses;
using App.FIN.Models.Requests;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using System.Xml;
using System.Drawing;

namespace App.FIN
{
    public class FinServices : IFinServices
    {
        private readonly CGI_MISContext _database;

        public FinServices(CGI_MISContext context)
        {
            _database = context;
        }

    }

}
