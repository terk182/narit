using App.ACC;
using App.GL;
using App.GL.Requests;
using AutoMapper.Configuration.Conventions;
using Microsoft.AspNetCore.Mvc;
using narit_acc_api.Models;

namespace narit_acc_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountingController : Controller
    {
        protected readonly IGlServices _IGlServices;
        private readonly ILogger _Logger;

        public AccountingController(ILogger<AccountingController> logger, IGlServices Service)
        {
            _IGlServices = Service;
            _Logger = logger;

        }
       
    }
}