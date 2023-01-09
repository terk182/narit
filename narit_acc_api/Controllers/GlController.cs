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
        [Route("Chart/Header")]
        public IActionResult GetChartHeader()
        {

            var data = _AccGlServices.GetChartHeader();
            return Json(data);
        }

        //SubHeader
        [HttpGet]
        [Route("Chart/SubHeader")]
        public IActionResult GetChartSubHeader(int ChartHeaderId)
        {
            var data = _AccGlServices.GetChartSubHeader(ChartHeaderId);
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
        [Route("Chart/Major")]
        public IActionResult GetChartMajor(int ChartSubHeaderId)
        {
            var data = _AccGlServices.GetChartMajor(ChartSubHeaderId);
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
        [Route("Chart/SubMajor")]
        public IActionResult GetChartSubMajor(int ChartMajorId)
        {
            var data = _AccGlServices.GetChartSubMajor(ChartMajorId);
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



    }
}
