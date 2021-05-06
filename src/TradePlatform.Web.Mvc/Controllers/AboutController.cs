using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TradePlatform.Controllers;

namespace TradePlatform.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : TradePlatformControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
