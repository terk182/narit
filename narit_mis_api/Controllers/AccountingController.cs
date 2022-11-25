using App.ACC;
using App.Common;
using App.SEC;
using Microsoft.AspNetCore.Mvc;

namespace narit_mis_api.Controllers
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
        [Route("Accounting/test")]
        public IActionResult MainGeneralUserPage()
        {
            var data = _AccServices.GetAccbooks();
            return Json(data);
        }
    }
}
