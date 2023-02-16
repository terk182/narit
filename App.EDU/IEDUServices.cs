using App.EDU.Responses;
using App.GL.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EDU
{
    public interface IEDUServices
    {
        Task<loginResponse> LoginCgiEduApi(loginRequest request);
        Task<StudentResponse> student(string q);
    }
}
