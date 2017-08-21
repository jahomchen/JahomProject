using System.Web.Mvc;

namespace JahomProject.Web.Controllers
{
    public class AboutController : JahomProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}