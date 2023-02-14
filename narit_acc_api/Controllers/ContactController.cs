using App.Acc.Contact;
using App.Acc.Contact.Requests;
using App.Acc.GL;
using App.Acc.GL.Requests;
using Microsoft.AspNetCore.Mvc;
using narit_acc_api.Models;

namespace narit_acc_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
            
        protected readonly IContactServices _AccContactServices;
        private readonly ILogger _Logger;
        public ContactController(ILogger<ContactController> logger, IContactServices Service)
        {
            _AccContactServices = Service;
            _Logger = logger;
        }

        /// <summary>
        /// ค้นหาผู้ติดต่อทั้งหมด
        /// </summary>
        [HttpGet]
        [Route("GetContactMainAll")]
        public IActionResult GetContactMainAll()
        {
            var data = _AccContactServices.GetContactMainAll();
            return Json(data);
        }

        /// <summary>
        /// เพิ่มผู้ติดต่อ โดย ID
        /// </summary>
        [HttpPost]
        [Route("GetContactMainId")]
        public IActionResult GetContactMainId(int Id)
        {
            var data = _AccContactServices.GetContactMainId(Id);
            return Json(data);
        }

        /// <summary>
        /// ค้นหาผู้ติดต่อทั้งหมด
        /// </summary>
        [HttpGet]
        [Route("GetContactMain")]
        public IActionResult GetContactMain()
        {
            var data = _AccContactServices.GetContactMain();
            return Json(data);
        }

        /// <summary>
        /// เพิ่มผู้ติดต่อ
        /// </summary>
        [HttpPost]
        [Route("AddContactMain")]
        public IActionResult AddContactMain(ContactMainRequest request)
        {
            var data = _AccContactServices.AddContactMain(request);
            return Json(data);
        }

        /// <summary>
        /// ค้นหาที่อยู่จัดส่งเอกสาร โดย ContactMainId
        /// </summary>
        [HttpGet]
        [Route("GetContactRefByContactMainId")]
        public IActionResult GetContactRefByContactId(int ContactId)
        {
            var data = _AccContactServices.GetContactRefByContactId(ContactId);
            return Json(data);
        }

        /// <summary>
        /// ค้นหาข้อมูลบุคคลที่ติดต่อได้ โดย ContactMainId
        /// </summary>
        [HttpGet]
        [Route("GetContactPersonByContactId")]
        public IActionResult GetContactPersonByContactId(int ContactId)
        {
            var data = _AccContactServices.GetContactPersonByContactId(ContactId);
            return Json(data);
        }

        /// <summary>
        /// ค้นหาข้อมูลธนาคารคู่ค้า โดย ContactMainId
        /// </summary>
        [HttpGet]
        [Route("GetContactBankByContactId")]
        public IActionResult GetContactBankByContactId(int ContactId)
        {
            var data = _AccContactServices.GetContactBankByContactId(ContactId);
            return Json(data);
        }

        /// <summary>
        /// ค้นหาข้อมูลกำหนดบัญชี โดย ContactMainId
        /// </summary>
        [HttpGet]
        [Route("GetContactAccByContactId")]
        public IActionResult GetContactAccByContactId(int ContactId)
        {
            var data = _AccContactServices.GetContactAccByContactId(ContactId);
            return Json(data);
        }


    }
}
