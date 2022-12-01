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

namespace App.Authenticator
{
    public class AuthenticatorServices : IAuthenticatorServices
    {
        private readonly NARIT_MIS_LINKContext _database;
        private readonly IConfiguration Configuration;
        private string _LdapDomain;
        private string _LdapServerIp;
        public AuthenticatorServices(NARIT_MIS_LINKContext context, IConfiguration configuration)
        {
            Configuration = configuration;
            _database = context;
            _LdapDomain = Configuration["Ldap:LdapDomain"];
            _LdapServerIp = Configuration["Ldap:IpLdapSever"];
        }

        public LdapAuthenticatorBaseResponse LdapLogIn(AuthenticatorRequest request)
        {
            var respone = new LdapAuthenticatorBaseResponse();
            var user_data = new List<LdapData>();
            var _Ldap = new Ldap();
            string result_txt = "";

            try
            {
                System.DirectoryServices.DirectoryEntry myLdapConnection = _Ldap.createDirectoryEntry(_LdapServerIp, _LdapDomain, request.UserName, request.Password);
                DirectorySearcher search = new DirectorySearcher(myLdapConnection);
                search.Filter = "(cn=" + request.UserName + ")";

                // create an array of properties that we would like and  
                // add them to the search object  

                string[] requiredProperties = new string[] { "cn", "mail" };

                foreach (String property in requiredProperties)
                    search.PropertiesToLoad.Add(property);

                SearchResult result = search.FindOne();

                if (result != null)
                {
                    foreach (String property in requiredProperties)
                    {
                        foreach (Object myCollection in result.Properties[property])
                        {
                            user_data.Add(new LdapData
                            {
                                property = property,
                                data = myCollection.ToString()
                            });
                            //result_txt = String.Format("{0,-20} : {1}", property, myCollection.ToString());
                        }
                    }
                    respone.Success = user_data.Count() > 0 ? true : false;
                    respone.Messsage = "success";
                }

                else {
                    respone.Success = false;
                    respone.Messsage = "not found";
                }
               
            }

            catch (Exception e)
            {
                respone.Success = false;
                respone.Errors = "success";
                respone.Errors = e.Message;
            }

            respone.data = user_data;
            return respone;
        }

        public AuthenticatorBaseResponse LogIn(AuthenticatorRequest request)
        {
            int checknullusername;
            int checknullpassword;
            Guid checkUserIdofUsername;
            Guid checkUserIdofPassword;
            var datausername = _database.AspnetUsers.Where(x => x.UserName == request.UserName).FirstOrDefault();
            if (datausername == null) { checknullusername = 0; }
            else { checknullusername = 1; }
            if (checknullusername == 0)
            {
                checkUserIdofUsername = Guid.Empty;
            }
            else
            {
                checkUserIdofUsername = datausername.UserId;
            }
            var datapassword = _database.AspnetMemberships.Where(x => x.Password == request.Password).FirstOrDefault();
            if (datapassword == null) { checknullpassword = 0; }
            else { checknullpassword = 1; }
            if (checknullpassword == 0)
            {
                checkUserIdofPassword = Guid.Empty;
            }
            else
            {
                checkUserIdofPassword = datapassword.UserId;
            }
            var response = new AuthenticatorBaseResponse();
            if (checkUserIdofUsername == checkUserIdofPassword && checkUserIdofUsername != Guid.Empty && checkUserIdofPassword != Guid.Empty)
            {
                response.Success = true;
                response.Messsage = "Congrats";
                response.userid = checkUserIdofUsername;

            }
            else if (checkUserIdofUsername == Guid.Empty && checkUserIdofPassword != Guid.Empty)
            {
                response.Success = false;
                response.Messsage = "Your username is wrong";
            }
            else if (checkUserIdofUsername != Guid.Empty && checkUserIdofPassword == Guid.Empty)
            {
                response.Success = false;
                response.Messsage = "Your password is wrong";
            }
            else
            {
                response.Success = false;
                response.Messsage = "Your username and password are wrong";
            }
            return response;
        }

     
    }
}
