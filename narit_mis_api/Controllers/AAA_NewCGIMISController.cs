using App.NewCGIMIS;
using App.Plan;
using App.SEC;
using Microsoft.AspNetCore.Mvc;
using narit_mis_api.Models;

namespace narit_mis_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AAA_NewCGIMISController : Controller
    {
        protected readonly INewCGIMISServices _Services;
        private readonly ILogger _Logger;
        public AAA_NewCGIMISController(ILogger<AAA_NewCGIMISController> logger, INewCGIMISServices Services)
        {
            _Services = Services;
            _Logger = logger;
        }
        /////////////////////////////////new new new by ardin/////////////////////////////////
        //MainGovtStatement
        [HttpGet]
        [Route("/MainGovtStatement/GetAll")]
        public IActionResult GetAllMainGovtStatement()
        {
            var data = _Services.GetAllMainGovtStatement();
            return Json(data);
        }
        [HttpGet]
        [Route("/MainGovtStatement/GetbyFisicalYear/{FisicalYear}")]
        public IActionResult GetMainGovtStatementbyFisicalYear(int FisicalYear)
        {
            var data = _Services.GetMainGovtStatementbyFisicalYear(FisicalYear);
            return Json(data);
        }
        [HttpGet]
        [Route("/MainGovtStatement/GetbyId/{MainGovtStatementId}")]
        public IActionResult GetMainGovtStatementbyId(int MainGovtStatementId)
        {
            var data = _Services.GetMainGovtStatementbyId(MainGovtStatementId);
            return Json(data);
        }
        [HttpPost]
        [Route("/MainGovtStatement/Setup")]
        public IActionResult MainGovtStatementSetup(MainGovtStatement request)
        {
            var data = _Services.MainGovtStatementSetup(request);
            return Json(data);
        }
        [HttpDelete]
        [Route("/MainGovtStatement/Delete/{MainGovtStatementId}")]
        public IActionResult DeleteMainGovtStatement(int MainGovtStatementId)
        {

            var data = _Services.DeleteMainGovtStatement(MainGovtStatementId);

            return Json(data);
        }
    }
}
