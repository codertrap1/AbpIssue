using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SpeedTest.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SpeedTestControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}