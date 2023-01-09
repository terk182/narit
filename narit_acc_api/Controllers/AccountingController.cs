using App.ACC;
using Microsoft.AspNetCore.Mvc;

namespace narit_acc_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountingController : Controller
    {
        protected readonly IAccServices _AccServices;
        private readonly ILogger _Logger;

        public AccountingController(ILogger<AccountingController> logger, IAccServices Service)
        {
            _AccServices = Service;
            _Logger = logger;

        }
        [HttpGet]
        [Route("Accounting/testTTTT")]
        public IActionResult MainGeneralUserPage()
        {
            var data = _AccServices.GetAccbooks();
            return Json(data);
        }
    }
}
