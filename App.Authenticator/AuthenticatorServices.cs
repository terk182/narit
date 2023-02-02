using narit_mis_api.Models;
using App.Authenticator.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App.Authenticator.Models.Requests;
using Microsoft.Extensions.Configuration;
using System.Reflection.PortableExecutable;
using App.Authenticator.helper;
using System.DirectoryServices;
using App.Authenticator.Models.Dtos;
using App.Authenticator.Dtos;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace App.Authenticator
{
    public class AuthenticatorServices : IAuthenticatorServices
    {
        private readonly CGI_MISContext _database;
        private readonly IConfiguration Configuration;
        private string _LdapDomain;
        private string _LdapServerIp;
        public AuthenticatorServices(CGI_MISContext context, IConfiguration configuration)
        {
            Configuration = configuration;
            _database = context;
            _LdapDomain = Configuration["Ldap:LdapDomain"];
            _LdapServerIp = Configuration["Ldap:IpLdapSever"];
        }

      

      
    }
}
