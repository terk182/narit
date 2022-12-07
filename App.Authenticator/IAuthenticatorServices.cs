using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using App.Authenticator.Dtos;
using App.Authenticator.Models.Requests;
using App.Authenticator.Models.Responses;

namespace App.Authenticator
{
    public interface IAuthenticatorServices
    {
        AuthenticatorBaseResponse LogIn(AuthenticatorRequest request);
        LdapAuthenticatorBaseResponse LdapLogIn(AuthenticatorRequest request);
        AuthenticatorBaseResponse LogInCheck(AuthenticatorRequest request);
        List<StaffDto> getAllUser();
        List<StaffDto> getUserId(int id);
        UserResponse deleteUser(int id);
    }

}
