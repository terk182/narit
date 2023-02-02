using App.Common.Dtos;
using App.Common.Helper;
using App.SEC.Dtos;
using App.SEC.enums;
using App.SEC.helper;
using App.SEC.Models;
using App.SEC.Models.Requests;
using App.SEC.Models.Responses;
using App.SEC.Responses;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using narit_mis_api.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace App.SEC
{
    public class SecServices : ISecServices
    {
        private readonly CGI_MISContext _database;

        public SecServices(CGI_MISContext context)
        {
            _database = context;
        }

        public List<ScheduleFisicalYear> GetScheduleFisicalYear()
        {
            List<ScheduleFisicalYear> schedules = _database.ScheduleFisicalYears.ToList();
            return schedules;
        }

        public List<ScheduleFisicalYear> GetScheduleFisicalYearByYears(string name, bool active)
        {
            List<ScheduleFisicalYear> schedules = _database.ScheduleFisicalYears.Where(x=>x.Name == name && x.Active == active).ToList();
            return schedules;
        }
    }
}

