using App.GL;
using App.GL.DTO;
using App.GL.Requests;
using App.GL.Responses;
using Microsoft.AspNetCore.Mvc;
using narit_acc_api.Models;

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

        /// <summary>
        /// ค้นหาผังบัญชีทั้งหมด
        /// </summary>
        [HttpGet]
        [Route("Chart/GetChartAll")]
        public IActionResult GetChartAll()
        {
            var data = _AccGlServices.GetChartAll();
            return Json(data);
        }
        //Header
        /// <summary>
        /// ค้นหาผังบัญชีชั้น 1
        /// </summary>
        [HttpGet]
        [Route("Chart/GetHeader")]
        public IActionResult GetChartHeader()
        {
            var data = _AccGlServices.GetChartHeader();
            return Json(data);
        }

        /// <summary>
        /// ค้นหาผังบัญชีชั้น 1 โดย ID
        /// </summary>
        [HttpGet]
        [Route("Chart/GetHeaderId")]
        public IActionResult GetChartHeaderId(int Id)
        {
            var data = _AccGlServices.GetChartHeaderId(Id);
            return Json(data);
        }

        //SubHeader
        /// <summary>
        /// ค้นหาผังบัญชีชั้น 2  ใน ชั้น 1
        /// </summary>
        [HttpGet]
        [Route("Chart/GetSubHeader")]
        public IActionResult GetChartSubHeader(int ChartHeaderId)
        {
            var data = _AccGlServices.GetChartSubHeader(ChartHeaderId);
            return Json(data);
        }

        /// <summary>
        /// ค้นหาผังบัญชีชั้น 2 โดย ID
        /// </summary>
        [HttpGet]
        [Route("Chart/GetSubHeaderId")]
        public IActionResult GetChartSubHeaderId(int Id)
        {
            var data = _AccGlServices.GetChartSubHeaderId(Id);
            return Json(data);
        }

        /// <summary>
        /// เพิ่มผังบัญชีชั้น 2
        /// </summary>
        [HttpPost]
        [Route("Chart/AddSubHeader")]
        public IActionResult AddSubHeader(ChartRequest Request)
        {
            var data = _AccGlServices.AddSubHeader(Request);
            return Json(data);
        }

        /// <summary>
        /// แก้ไขผังบัญชีชั้น 2
        /// </summary>
        [HttpPost]
        [Route("Chart/EditSubHeader")]
        public IActionResult EditSubHeader(EditChartRequest request)
        {
            var data = _AccGlServices.EditSubHeader(request);

            return Json(data);
        }

        /// <summary>
        /// ลบผังบัญชีชั้น 2
        /// </summary>
        [HttpDelete]
        [Route("Chart/DeleteSubHeader")]
        public IActionResult DelSubHeader(int Id)
        {
            var data = _AccGlServices.DelSubHeader(Id);
            return Json(data);
        }

        //Major
        /// <summary>
        /// ค้นหาผังบัญชีชั้น 3  ใน ชั้น 2
        /// </summary>
        [HttpGet]
        [Route("Chart/GetMajor")]
        public IActionResult GetChartMajor(int ChartSubHeaderId)
        {
            var data = _AccGlServices.GetChartMajor(ChartSubHeaderId);
            return Json(data);
        }

        /// <summary>
        /// ค้นหาผังบัญชีชั้น 3 โดย ID
        /// </summary>
        [HttpGet]
        [Route("Chart/GetMajorId")]
        public IActionResult GetChartMajorId(int Id)
        {
            var data = _AccGlServices.GetChartMajorId(Id);
            return Json(data);
        }

        /// <summary>
        /// เพิ่มผังบัญชีชั้น 3
        /// </summary>
        [HttpPost]
        [Route("Chart/AddMajor")]
        public IActionResult AddMajor(ChartRequest Request)
        {
            var data = _AccGlServices.AddMajor(Request);
            return Json(data);
        }

        /// <summary>
        /// แก้ไขผังบัญชีชั้น 3
        /// </summary>
        [HttpPost]
        [Route("Chart/EditMajor")]
        public IActionResult EditMajor(EditChartRequest request)
        {
            var data = _AccGlServices.EditMajor(request);

            return Json(data);
        }

        /// <summary>
        /// ลบผังบัญชีชั้น 3 
        /// </summary>
        [HttpDelete]
        [Route("Chart/DeleteMajor")]
        public IActionResult DelMajor(int Id)
        {
            var data = _AccGlServices.DelMajor(Id);
            return Json(data);
        }

        //Submajor
        /// <summary>
        /// ค้นหาผังบัญชีชั้น 4  ใน ชั้น 3
        /// </summary>
        [HttpGet]
        [Route("Chart/GetSubMajor")]
        public IActionResult GetChartSubMajor(int ChartMajorId)
        {
            var data = _AccGlServices.GetChartSubMajor(ChartMajorId);
            return Json(data);
        }

        /// <summary>
        /// ค้นหาผังบัญชีชั้น 4 โดย ID
        /// </summary>
        [HttpGet]
        [Route("Chart/GetSubMajorId")]
        public IActionResult GetChartSubMajorId(int Id)
        {
            var data = _AccGlServices.GetChartSubMajorId(Id);
            return Json(data);
        }

        /// <summary>
        /// เพิ่มผังบัญชีชั้น 4
        /// </summary>
        [HttpPost]
        [Route("Chart/AddSubMajor")]
        public IActionResult AddSubMajor(ChartRequest Request)
        {
            var data = _AccGlServices.AddSubMajor(Request);
            return Json(data);
        }

        /// <summary>
        /// แก้ไขผังบัญชีชั้น 4
        /// </summary>
        [HttpPost]
        [Route("Chart/EditSubMajor")]
        public IActionResult EditSubMajor(EditChartRequest request)
        {
            var data = _AccGlServices.EditSubMajor(request);

            return Json(data);
        }

        /// <summary>
        /// ลบผังบัญชีชั้น 4
        /// </summary>
        [HttpDelete]
        [Route("Chart/DeleteSubMajor")]
        public IActionResult DelSubMajor(int Id)
        {
            var data = _AccGlServices.DelSubMajor(Id);
            return Json(data);
        }

        //Minor
        /// <summary>
        /// ค้นหาผังบัญชีชั้น 5
        /// </summary>
        [HttpGet]
        [Route("Chart/GetAllMinor")]
        public IActionResult GetAllChartMinor()
        {
            var data = _AccGlServices.GetAllChartMinor();
            return Json(data);
        }

        /// <summary>
        /// ค้นหาผังบัญชีชั้น 5 ใน ชั้น 4
        /// </summary>
        [HttpGet]
        [Route("Chart/GetMinor")]
        public IActionResult GetChartMinor(int ChartSubMajorId)
        {
            var data = _AccGlServices.GetChartMinor(ChartSubMajorId);
            return Json(data);
        }

        /// <summary>
        /// ค้นหาผังบัญชีชั้น 5 โดย ID
        /// </summary>
        [HttpGet]
        [Route("Chart/GetMinorId")]
        public IActionResult GetChartMinorId(int Id)
        {
            var data = _AccGlServices.GetChartMinorId(Id);
            return Json(data);
        }

        /// <summary>
        /// เพิ่มผังบัญชีชั้น 5
        /// </summary>
        [HttpPost]
        [Route("Chart/AddMinor")]
        public IActionResult AddMinor(ChartRequest Request)
        {
            var data = _AccGlServices.AddMinor(Request);
            return Json(data);
        }

        /// <summary>
        /// แก้ไขผังบัญชีชั้น 5
        /// </summary>
        [HttpPost]
        [Route("Chart/EditMinor")]
        public IActionResult EditMinor(EditChartRequest request)
        {
            var data = _AccGlServices.EditMinor(request);

            return Json(data);
        }

        /// <summary>
        /// ลบผังบัญชีชั้น 5
        /// </summary>
        [HttpDelete]
        [Route("Chart/DeleteMinor")]
        public IActionResult DelMinorr(int Id)
        {
            var data = _AccGlServices.DelMinor(Id);
            return Json(data);
        }


        // ชั้น 6
        //SubMinor
        //[HttpGet]
        //[Route("Chart/GetAllSubMinor")]
        //public IActionResult GetAllChartSubMinor()
        //{
        //    var data = _AccGlServices.GetAllChartSubMinor();
        //    return Json(data);
        //}

        //[HttpGet]
        //[Route("Chart/GetSubMinor")]
        //public IActionResult GetChartSubMinor(int ChartMinorId)
        //{
        //    var data = _AccGlServices.GetChartSubMinor(ChartMinorId);
        //    return Json(data);
        //}

        //[HttpGet]
        //[Route("Chart/GetSubMinorId")]
        //public IActionResult GetChartSubMinorId(int id)
        //{
        //    var data = _AccGlServices.GetChartSubMinorId(id);
        //    return Json(data);
        //}

        //[HttpPost]
        //[Route("Chart/AddSubMinor")]
        //public IActionResult AddSubMinor(SubMinorRequest Request)
        //{
        //    var data = _AccGlServices.AddSubMinor(Request);
        //    return Json(data);
        //}

        //[HttpPost]
        //[Route("Chart/EditSubMinor")]
        //public IActionResult EditSubMinor(EditSubMinorRequest request)
        //{
        //    var data = _AccGlServices.EditSubMinor(request);

        //    return Json(data);
        //}

        //[HttpDelete]
        //[Route("Chart/DeleteSubMinor")]
        //public IActionResult DelSubMinorr(int Id)
        //{
        //    var data = _AccGlServices.DelSubMinor(Id);
        //    return Json(data);
        //}

        /// <summary>
        /// ค้นหาประเภทบัญชี
        /// </summary>
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

        /// <summary>
        /// ค้นหาประเภทบัญชี โดย ID
        /// </summary>
        [HttpGet]
        [Route("AccType/GetAccountTypeId")]
        public IActionResult GetAccountTypeId(int Id)
        {
            var data = _AccGlServices.GetAccountTypeId(Id);
            if (data != null)
            {
                return Json(data);
            }
            return Json(data);
        }

        /// <summary>
        /// เพิ่มประเภทบัญชี
        /// </summary>
        [HttpPost]
        [Route("AccType/AddAccountType")]
        public IActionResult AddAccountType(CreateAccountTypeRequest Request)
        {
            var data = _AccGlServices.AddAccountType(Request);
            return Json(data);
        }

        /// <summary>
        /// แก้ไขประเภทบัญชี
        /// </summary>
        [HttpPost]
        [Route("AccType/EditAccountType")]
        public IActionResult EditAccountType(CreateAccountTypeRequest Request)
        {
            var data = _AccGlServices.EditAccountType(Request);
            return Json(data);
        }

        /// <summary>
        /// ลบประเภทบัญชี
        /// </summary>
        [HttpDelete]
        [Route("AccType/DeleteAccountTypeId")]
        public IActionResult DeleteAccountTypeId(int Id)
        {
            var data = _AccGlServices.DeleteAccountTypeId(Id);
            return Json(data);
        }


        /// <summary>
        /// ค้นหาประเภทลูกหนี้
        /// </summary>
        [HttpGet]
        [Route("Debtor/GetDebtorType")]
        public IActionResult GetDebtorType()
        {
            var data = _AccGlServices.GetDebtorType();
            return Json(data);
        }

        /// <summary>
        /// ค้นหาประเภทลูกหนี้ โดย ID
        /// </summary>
        [HttpGet]
        [Route("Debtor/GetDebtorTypeId")]
        public IActionResult GetDebtorTypeId(int Id)
        {
            var data = _AccGlServices.GetDebtorTypeId(Id);
            return Json(data);
        }

        /// <summary>
        /// เพิ่มประเภทลูกหนี้
        /// </summary>
        [HttpPost]
        [Route("Debtor/AddDebtorType")]
        public IActionResult AddDebtorType(DebtorTypeRequest Request)
        {
            var data = _AccGlServices.AddDebtorType(Request);
            return Json(data);
        }

        /// <summary>
        /// แก้ไขประเภทลูกหนี้
        /// </summary>
        [HttpPost]
        [Route("Debtor/EditDebtorType")]
        public IActionResult EditDebtorType(DebtorTypeRequest Request)
        {
            var data = _AccGlServices.EditDebtorType(Request);
            return Json(data);
        }

        /// <summary>
        /// ค้นหาประเภทลูกหนี้
        /// </summary>
        [HttpDelete]
        [Route("Debtor/DeleteDebtorTypeId")]
        public IActionResult DeleteDebtorTypeId(int Id)
        {
            var data = _AccGlServices.DeleteDebtorTypeId(Id);
            return Json(data);
        }

        /// <summary>
        /// ค้นหาลูกหนี้
        /// </summary>
        [HttpGet]
        [Route("Debtor/GetAllDeletor")]
        public IActionResult GetAllDebtor()
        {
            var data = _AccGlServices.GetAllDebtor();
            return Json(data);
        }


        /// <summary>
        /// ค้นหาประเภทเจ้าหนี้
        /// </summary>
        [HttpGet]
        [Route("Creditor/GetCreditorType")]
        public IActionResult GetCreditorType()
        {
            var data = _AccGlServices.GetCreditorType();
            return Json(data);
        }

        /// <summary>
        /// ค้นหาประเภทเจ้าหนี้ โดย ID
        /// </summary>
        [HttpGet]
        [Route("Creditor/GetCreditorTypeId")]
        public IActionResult GetCreditorTypeId(int Id)
        {
            var data = _AccGlServices.GetCreditorTypeId(Id);
            return Json(data);
        }

        /// <summary>
        /// เพิ่มประเภทเจ้าหนี้
        /// </summary>
        [HttpPost]
        [Route("Creditor/AddCreditorType")]
        public IActionResult AddCreditorType(CreditorTypeRequest Request)
        {
            var data = _AccGlServices.AddCreditorType(Request);
            return Json(data);
        }

        /// <summary>
        /// แก้ไขประเภทเจ้าหนี้
        /// </summary>
        [HttpPost]
        [Route("Creditor/EditCreditorType")]
        public IActionResult EditCreditorType(CreditorTypeRequest Request)
        {
            var data = _AccGlServices.EditCreditorType(Request);
            return Json(data);
        }

        /// <summary>
        /// ลบประเภทเจ้าหนี้
        /// </summary>
        [HttpDelete]
        [Route("Creditor/DeletetCreditorTypeId")]
        public IActionResult DeletetCreditorTypeId(int Id)
        {
            var data = _AccGlServices.DeletetCreditorTypeId(Id);
            return Json(data);
        }

        /// <summary>
        /// ค้นหาเจ้าหนี้
        /// </summary>
        [HttpGet]
        [Route("Creditor/GetCreditor")]
        public IActionResult GetCreditor()
        {
            var data = _AccGlServices.GetCreditor();
            return Json(data);
        }

        /// <summary>
        /// ค้นหาเจ้าหนี้ โดย ID
        /// </summary>
        [HttpGet]
        [Route("Creditor/GetCreditorId")]
        public IActionResult GetCreditorId(int Id)
        {
            var data = _AccGlServices.GetCreditorId(Id);
            return Json(data);
        }

        /// <summary>
        /// เพิ่มเจ้าหนี้
        /// </summary>
        [HttpPost]
        [Route("Creditor/AddCreditor")]
        public IActionResult AddCreditor(CreditorRequest Request)
        {
            var data = _AccGlServices.AddCreditor(Request);
            return Json(data);
        }

        /// <summary>
        /// แก้ไขเจ้าหนี้
        /// </summary>
        [HttpPost]
        [Route("Creditor/EditCreditor")]
        public IActionResult EditCreditor(CreditorRequest Request)
        {
            var data = _AccGlServices.EditCreditor(Request);
            return Json(data);
        }

        /// <summary>
        /// ลบเจ้าหนี้
        /// </summary>
        [HttpDelete]
        [Route("Creditor/DeleteCreditor")]
        public IActionResult DeleteCreditorId(int Id)
        {
            var data = _AccGlServices.DeleteCreditorId(Id);
            return Json(data);
        }

        /// <summary>
        /// ค้นหา Transection
        /// </summary>
        [HttpGet]
        [Route("Transection/GetTransection")]
        public IActionResult GetTransection()
        {
            var data = _AccGlServices.GetTransection();
            return Json(data);
        }

        /// <summary>
        /// ค้นหา Transection โดย ID
        /// </summary>
        [HttpGet]
        [Route("Transection/GetTransectionId")]
        public IActionResult GetTransectionId(int Id)
        {
            var data = _AccGlServices.GetTransectionId(Id);
            return Json(data);
        }

        /// <summary>
        /// แก้ไข Transection
        /// </summary>
        [HttpPost]
        [Route("Transection/EditTransection")]
        public IActionResult EditTransection(EditTransectionRequest Request)
        {
            var data = _AccGlServices.EditTransection(Request);
            return Json(data);
        }

        /// <summary>
        /// ค้นหาสมุดรายวัน
        /// </summary>
        [HttpGet]
        [Route("Journal/GetJournal")]
        public IActionResult GetJournal()
        {
            var data = _AccGlServices.GetJournal();
            return Json(data);
        }

        /// <summary>
        /// ค้นหาสมุดรายวัน โดย ID
        /// </summary>
        [HttpGet]
        [Route("Journal/GetJournalID")]
        public IActionResult GetJournalID(int Id)
        {
            var data = _AccGlServices.GetJournalID(Id);
            return Json(data);
        }


        /// <summary>
        /// ค้นหาสมุดย่อย โดย JournalID
        /// </summary>
        [HttpGet]
        [Route("Journal/GetSubJournal")]
        public IActionResult GetSubJournal(int JournalID)
        {
            var data = _AccGlServices.GetSubJournal(JournalID);
            return Json(data);
        }

        /// <summary>
        /// เพิ่มสมุดย่อย โดย ID
        /// </summary>
        [HttpGet]
        [Route("Journal/GetSubJournalID")]
        public IActionResult GetSubJournalID(int Id)
        {
            var data = _AccGlServices.GetSubJournalID(Id);
            return Json(data);
        }

        /// <summary>
        /// เพิ่มสมุดย่อย
        /// </summary>
        [HttpPost]
        [Route("Journal/AddSubJournal")]
        public IActionResult AddSubJournal(SubJournalResponse Request)
        {
            var data = _AccGlServices.AddSubJournal(Request);
            return Json(data);
        }
   
        /// <summary>
        /// แก้ไขสมุดย่อย
        /// </summary>
        /// <remarks>
         /// แก้ไข
        /// </remarks>
        [HttpPost]
        [Route("Journal/EditSubJournal")]
        public IActionResult EditSubJournal(SubJournalDto Request)
        {
            var data = _AccGlServices.EditSubJournal(Request);
            return Json(data);
        }

        [HttpGet]
        [Route("Chart/ReportGlAll")]
        public IActionResult ReportGlAll()
        {
            var data = _AccGlServices.ReportGlAll();
            return Json(data);
        }

        ////[HttpGet]
        ////[Route("Chart/reportchart")]
        ////public IActionResult reportchart(DateTime? DetailDate, int? MinorID)
        ////{
        ////    var data = _AccGlServices.reportchart(DetailDate, MinorID);
        ////    return Json(data);
        ////}

        [HttpPost]
        [Route("Chart/reportchartdate")]
        public IActionResult reportchartdate(ReportChartRequest request)
        {
            var data = _AccGlServices.reportchartdate(request);
            return Json(data);
        }

        /// <summary>
        /// รายงานบัญชีแยกประเภท
        /// </summary>
        /// <remarks>
        /// ** SelectDate เป็น int <br/> 
        /// 1 = เลือกวันที่ <br/> 
        /// 2 = ย้อนหลัง 1 เดือน <br/> 
        /// 3 = ย้อนหลัง 3 เดือน 
        /// </remarks>
        [HttpPost]
        [Route("Chart/ReportGlDate")]
        public IActionResult PostReportGlDate(ReportChartRequest request)
        {
            var data = _AccGlServices.PostReportGlDate(request);
            return Json(data);
        }


        /// <summary>
        /// ค้นหาประเภทกำหนดใบเสร็จและใบสำคัญ(ทั้งหมด)
        /// </summary>
        [HttpGet]
        [Route("Document/GetDocumentType")]
        public IActionResult GetDocumentType()
        {
            var data = _AccGlServices.GetDocumentType();
            return Json(data);
        }

        /// <summary>
        /// ค้นหากำหนดใบเสร็จและใบสำคัญ(ทั้งหมด)
        /// </summary>
        [HttpGet]
        [Route("Document/GetDocument")]
        public IActionResult GetDocument(int Active)
        {
            var data = _AccGlServices.GetDocument(Active);
            return Json(data);
        }
        /// <summary>
        /// ค้นหากำหนดใบเสร็จและใบสำคัญ โดย ID
        /// </summary>
        [HttpGet]
        [Route("Document/GetDocumentID")]
        public IActionResult GetDocumentId(int Id)
        {
            var data = _AccGlServices.GetDocumentId(Id);
            return Json(data);
        }

        /// <summary>
        /// เพิ่มใบเสร็จและใบสำคัญ
        /// </summary>
        [HttpPost]
        [Route("Document/AddDocument")]
        public IActionResult AddDocument(DocumentRequest Request)
        {
            var data = _AccGlServices.AddDocument(Request);
            return Json(data);
        }

        /// <summary>
        /// แก้ไขใบเสร็จและใบสำคัญ
        /// </summary>
        [HttpPost]
        [Route("Document/EditDocument")]
        public IActionResult EditDocument(DocumentRequest Request)
        {
            var data = _AccGlServices.EditDocument(Request);
            return Json(data);
        }

        /// <summary>
        /// Activeใบเสร็จและใบสำคัญ
        /// </summary>
        [HttpDelete]
        [Route("Document/ActiveDocument")]
        public IActionResult ActiveDocument(int Id , int Active)
        {
            var data = _AccGlServices.ActiveDocument(Id, Active);
            return Json(data);
        }

    }
}
