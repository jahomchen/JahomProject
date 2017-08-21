using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace JahomProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : JahomProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}