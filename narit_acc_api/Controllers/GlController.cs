using App.GL;
using App.GL.Requests;
using Microsoft.AspNetCore.Mvc;

namespace narit_acc_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GLController : Controller
    {
        protected readonly IGlServices _AccGlServices;
        private readonly ILogger _Logger;
        public GLController(ILogger<GLController> logger, IGlServices Service)
        {
            _AccGlServices = Service;
            _Logger = logger;
        }

        //Header
        [HttpGet]
        [Route("Chart/GetHeader")]
        public IActionResult GetChartHeader()
        {
            var data = _AccGlServices.GetChartHeader();
            return Json(data);
        }

        [HttpGet]
        [Route("Chart/GetHeaderId")]
        public IActionResult GetChartHeaderId(int id)
        {
            var data = _AccGlServices.GetChartHeaderId(id);
            return Json(data);
        }

        //SubHeader
        [HttpGet]
        [Route("Chart/GetSubHeader")]
        public IActionResult GetChartSubHeader(int ChartHeaderId)
        {
            var data = _AccGlServices.GetChartSubHeader(ChartHeaderId);
            return Json(data);
        }

        [HttpGet]
        [Route("Chart/GetSubHeaderId")]
        public IActionResult GetChartSubHeaderId(int id)
        {
            var data = _AccGlServices.GetChartSubHeaderId(id);
            return Json(data);
        }

        [HttpPost]
        [Route("Chart/AddSubHeader")]
        public IActionResult AddSubHeader(ChartRequest Request)
        {
            var data = _AccGlServices.AddSubHeader(Request);
            return Json(data);
        }

        [HttpPost]
        [Route("Chart/EditSubHeader")]
        public IActionResult EditSubHeader(EditChartRequest request)
        {
            var data = _AccGlServices.EditSubHeader(request);

            return Json(data);
        }

        [HttpDelete]
        [Route("Chart/DeleteSubHeader")]
        public IActionResult DelSubHeader(int Id)
        {
            var data = _AccGlServices.DelSubHeader(Id);
            return Json(data);
        }

        //Major
        [HttpGet]
        [Route("Chart/GetMajor")]
        public IActionResult GetChartMajor(int ChartSubHeaderId)
        {
            var data = _AccGlServices.GetChartMajor(ChartSubHeaderId);
            return Json(data);
        }

        [HttpGet]
        [Route("Chart/GetMajorId")]
        public IActionResult GetChartMajorId(int id)
        {
            var data = _AccGlServices.GetChartMajorId(id);
            return Json(data);
        }

        [HttpPost]
        [Route("Chart/AddMajor")]
        public IActionResult AddMajor(ChartRequest Request)
        {
            var data = _AccGlServices.AddMajor(Request);
            return Json(data);
        }

        [HttpPost]
        [Route("Chart/EditMajor")]
        public IActionResult EditMajor(EditChartRequest request)
        {
            var data = _AccGlServices.EditMajor(request);

            return Json(data);
        }

        [HttpDelete]
        [Route("Chart/DeleteMajor")]
        public IActionResult DelMajor(int Id)
        {
            var data = _AccGlServices.DelMajor(Id);
            return Json(data);
        }

        //Submajor
        [HttpGet]
        [Route("Chart/GetSubMajor")]
        public IActionResult GetChartSubMajor(int ChartMajorId)
        {
            var data = _AccGlServices.GetChartSubMajor(ChartMajorId);
            return Json(data);
        }

        [HttpGet]
        [Route("Chart/GetSubMajorId")]
        public IActionResult GetChartSubMajorId(int id)
        {
            var data = _AccGlServices.GetChartSubMajorId(id);
            return Json(data);
        }


        [HttpPost]
        [Route("Chart/AddSubMajor")]
        public IActionResult AddSubMajor(ChartRequest Request)
        {
            var data = _AccGlServices.AddSubMajor(Request);
            return Json(data);
        }

        [HttpPost]
        [Route("Chart/EditSubMajor")]
        public IActionResult EditSubMajor(EditChartRequest request)
        {
            var data = _AccGlServices.EditSubMajor(request);

            return Json(data);
        }

        [HttpDelete]
        [Route("Chart/DeleteSubMajor")]
        public IActionResult DelSubMajor(int Id)
        {
            var data = _AccGlServices.DelSubMajor(Id);
            return Json(data);
        }

        //Minor
        [HttpGet]
        [Route("Chart/GetMinor")]
        public IActionResult GetChartMinor(int ChartSubMajorId)
        {
            var data = _AccGlServices.GetChartMinor(ChartSubMajorId);
            return Json(data);
        }

        [HttpGet]
        [Route("Chart/GetMinorId")]
        public IActionResult GetChartMinorId(int id)
        {
            var data = _AccGlServices.GetChartMinorId(id);
            return Json(data);
        }

        [HttpPost]
        [Route("Chart/AddMinor")]
        public IActionResult AddMinor(ChartRequest Request)
        {
            var data = _AccGlServices.AddMinor(Request);
            return Json(data);
        }

        [HttpPost]
        [Route("Chart/EditMinor")]
        public IActionResult EditMinor(EditChartRequest request)
        {
            var data = _AccGlServices.EditMinor(request);

            return Json(data);
        }

        [HttpDelete]
        [Route("Chart/DeleteMinor")]
        public IActionResult DelMinorr(int Id)
        {
            var data = _AccGlServices.DelMinor(Id);
            return Json(data);
        }

        //SubMinor
        [HttpGet]
        [Route("Chart/GetSubMinor")]
        public IActionResult GetChartSubMinor(int ChartMinorId)
        {
            var data = _AccGlServices.GetChartSubMinor(ChartMinorId);
            return Json(data);
        }

        [HttpGet]
        [Route("Chart/GetSubMinorId")]
        public IActionResult GetChartSubMinorId(int id)
        {
            var data = _AccGlServices.GetChartSubMinorId(id);
            return Json(data);
        }

        [HttpPost]
        [Route("Chart/AddSubMinor")]
        public IActionResult AddSubMinor(SubMinorRequest Request)
        {
            var data = _AccGlServices.AddSubMinor(Request);
            return Json(data);
        }

        [HttpPost]
        [Route("Chart/EditSubMinor")]
        public IActionResult EditSubMinor(EditSubMinorRequest request)
        {
            var data = _AccGlServices.EditSubMinor(request);

            return Json(data);
        }

        [HttpDelete]
        [Route("Chart/DeleteSubMinor")]
        public IActionResult DelSubMinorr(int Id)
        {
            var data = _AccGlServices.DelSubMinor(Id);
            return Json(data);
        }

        [HttpGet]
        [Route("AccType/GetAccountType")]
        public IActionResult GetAccountType()
        {
            var data = _AccGlServices.GetAccountType();
            if (data != null)
            {
                return Json(data);
            }
            return Json(data);
        }

        [HttpGet]
        [Route("AccType/GetAccountTypeId")]
        public IActionResult GetAccountTypeId(int id)
        {
            var data = _AccGlServices.GetAccountTypeId(id);
            if (data != null)
            {
                return Json(data);
            }
            return Json(data);
        }

        [HttpPost]
        [Route("AccType/AddAccountType")]
        public IActionResult AddAccountType(CreateAccountTypeRequest Request)
        {
            var data = _AccGlServices.AddAccountType(Request);
            return Json(data);
        }

        [HttpPost]
        [Route("AccType/EditAccountType")]
        public IActionResult EditAccountType(CreateAccountTypeRequest Request)
        {
            var data = _AccGlServices.EditAccountType(Request);
            return Json(data);
        }

        [HttpDelete]
        [Route("AccType/DeleteAccountTypeId")]
        public IActionResult DeleteAccountTypeId(int Id)
        {
            var data = _AccGlServices.DeleteAccountTypeId(Id);
            return Json(data);
        }

        [HttpGet]
        [Route("ARType/GetDebtorType")]
        public IActionResult GetDebtorType()
        {
            var data = _AccGlServices.GetDebtorType();
            return Json(data);
        }

        [HttpGet]
        [Route("ARType/GetDebtorTypeId")]
        public IActionResult GetDebtorTypeId(int id)
        {
            var data = _AccGlServices.GetDebtorTypeId(id);
            return Json(data);
        }

        [HttpPost]
        [Route("ARType/AddDebtorType")]
        public IActionResult AddDebtorType(DebtorTypeRequest Request)
        {
            var data = _AccGlServices.AddDebtorType(Request);
            return Json(data);
        }

        [HttpPost]
        [Route("ARType/EditDebtorType")]
        public IActionResult EditDebtorType(DebtorTypeRequest Request)
        {
            var data = _AccGlServices.EditDebtorType(Request);
            return Json(data);
        }

        [HttpDelete]
        [Route("ARType/DeleteDebtorTypeId")]
        public IActionResult DeleteDebtorTypeId(int Id)
        {
            var data = _AccGlServices.DeleteDebtorTypeId(Id);
            return Json(data);
        }

        [HttpGet]
        [Route("APType/GetCreditorType")]
        public IActionResult GetCreditorType()
        {
            var data = _AccGlServices.GetCreditorType();
            return Json(data);
        }

        [HttpGet]
        [Route("APType/GetCreditorTypeId")]
        public IActionResult GetCreditorTypeId(int id)
        {
            var data = _AccGlServices.GetCreditorTypeId(id);
            return Json(data);
        }

        [HttpPost]
        [Route("APType/AddCreditorType")]
        public IActionResult AddCreditorType(CreditorTypeRequest Request)
        {
            var data = _AccGlServices.AddCreditorType(Request);
            return Json(data);
        }

        [HttpPost]
        [Route("APType/EditCreditorType")]
        public IActionResult EditCreditorType(CreditorTypeRequest Request)
        {
            var data = _AccGlServices.EditCreditorType(Request);
            return Json(data);
        }

        [HttpDelete]
        [Route("APType/DeletetCreditorTypeId")]
        public IActionResult DeletetCreditorTypeId(int Id)
        {
            var data = _AccGlServices.DeletetCreditorTypeId(Id);
            return Json(data);
        }

        [HttpGet]
        [Route("Creditor/GetCreditor")]
        public IActionResult GetCreditor()
        {
            var data = _AccGlServices.GetCreditor();
            return Json(data);
        }

        [HttpGet]
        [Route("Creditor/GetCreditorId")]
        public IActionResult GetCreditorId(int Id)
        {
            var data = _AccGlServices.GetCreditorId(Id);
            return Json(data);
        }

        [HttpPost]
        [Route("Creditor/AddCreditor")]
        public IActionResult AddCreditor(CreditorRequest Request)
        {
            var data = _AccGlServices.AddCreditor(Request);
            return Json(data);
        }

        [HttpPost]
        [Route("Creditor/EditCreditor")]
        public IActionResult EditCreditor(CreditorRequest Request)
        {
            var data = _AccGlServices.EditCreditor(Request);
            return Json(data);
        }

        [HttpDelete]
        [Route("Creditor/DeleteCreditor")]
        public IActionResult DeleteCreditorId(int Id)
        {
            var data = _AccGlServices.DeleteCreditorId(Id);
            return Json(data);
        }
    }
}
