using narit_mis_api.Models;
using App.Authenticator.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace App.Authenticator
{
    public class AuthenticatorServices : IAuthenticatorServices
    {
        private readonly NARIT_MIS_LINKContext _database;

        public AuthenticatorServices(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }
        public AuthenticatorBaseResponse LogIn(string username, string password)
        {
            int checknullusername;
            int checknullpassword;
            Guid checkUserIdofUsername;
            Guid checkUserIdofPassword;
            var datausername = _database.AspnetUsers.Where(x => x.UserName == username).FirstOrDefault();
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
            var datapassword = _database.AspnetMemberships.Where(x => x.Password == password).FirstOrDefault();
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
            if (checkUserIdofUsername == checkUserIdofPassword && checkUserIdofUsername != Guid.Empty && checkUserIdofPassword != Guid.Empty )
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
