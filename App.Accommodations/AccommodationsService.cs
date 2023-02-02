using App.Accommodations.Model.Requests;
using App.Accommodations.Model.Responses;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace App.Accommodations
{
    public class AccommodationsService : IAccommodationsService
    {
        private readonly CGI_MISContext _database;

        public AccommodationsService(CGI_MISContext context)
        {
            _database = context;
        }

     
    }
}
