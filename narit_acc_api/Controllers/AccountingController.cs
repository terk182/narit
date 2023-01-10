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
        [HttpGet]
        [Route("GetAccountType")]
        public IActionResult GetAccountType()
        {
            var data = _IGlServices.GetAccountType();
            if (data != null)
            {
                return Json(data);
            }
            return Json(data);
        }

        [HttpGet]
        [Route("GetAccountTypeId")]
        public IActionResult GetAccountTypeId(int id)
        {
            var data = _IGlServices.GetAccountTypeId(id);
            if (data != null)
            {
                return Json(data);
            }
            return Json(data);
        }

        [HttpPost]
        [Route("AddAccountType")]
        public IActionResult AddAccountType(CreateAccountTypeRequest Request)
        {
            var data = _IGlServices.AddAccountType(Request);
            return Json(data);
        }

        [HttpPost]
        [Route("EditAccountType")]
        public IActionResult EditAccountType(CreateAccountTypeRequest Request)
        {
            var data = _IGlServices.EditAccountType(Request);
            return Json(data);
        }

        [HttpDelete]
        [Route("DeleteAccountTypeId")]
        public IActionResult DeleteAccountTypeId(int Id)
        {
            var data = _IGlServices.DeleteAccountTypeId(Id);
            return Json(data);
        }

        [HttpGet]
        [Route("GetAccountReceivableType")]
        public IActionResult GetAccountReceivableType()
        {
            var data = _IGlServices.GetAccountReceivableType();
            return Json(data);
        }

        [HttpGet]
        [Route("GetAccountReceivableTypeId")]
        public IActionResult GetAccountReceivableTypeId(int id)
        {
            var data = _IGlServices.GetAccountReceivableTypeId(id);
            return Json(data);
        }

        [HttpPost]
        [Route("AddAccountReceivableType")]
        public IActionResult AddAccountReceivableType(AccountReceivableTypeRequest Request)
        {
            var data = _IGlServices.AddAccountReceivableType(Request);
            return Json(data);
        }

        [HttpPost]
        [Route("EditAccountReceivableType")]
        public IActionResult EditAccountReceivableType(AccountReceivableTypeRequest Request)
        {
            var data = _IGlServices.EditAccountReceivableType(Request);
            return Json(data);
        }

        [HttpDelete]
        [Route("DeleteAccountReceivableTypeId")]
        public IActionResult DeleteAccountReceivableTypeId(int Id)
        {
            var data = _IGlServices.DeleteAccountReceivableTypeId(Id);
            return Json(data);
        }

        [HttpGet]
        [Route("GetAccountPayableType")]
        public IActionResult GetAccountPayableType()
        {
            var data = _IGlServices.GetAccountPayableType();
            return Json(data);
        }

        [HttpGet]
        [Route("GetAccountPayableTypeId")]
        public IActionResult GetAccountPayableTypeId(int id)
        {
            var data = _IGlServices.GetAccountPayableTypeId(id);
            return Json(data);
        }

        [HttpPost]
        [Route("AddAccountPayableType")]
        public IActionResult AddAccountPayableType(AccountPayableTypeRequest Request)
        {
            var data = _IGlServices.AddAccountPayableType(Request);
            return Json(data);
        }

        [HttpPost]
        [Route("EditAccountPayableType")]
        public IActionResult EditAccountPayableType(AccountPayableTypeRequest Request)
        {
            var data = _IGlServices.EditAccountPayableType(Request);
            return Json(data);
        }

        [HttpDelete]
        [Route("DeletetAccountPayableTypeId")]
        public IActionResult DeletetAccountPayableTypeId(int Id)
        {
            var data = _IGlServices.DeletetAccountPayableTypeId(Id);
            return Json(data);
        }
    }
}