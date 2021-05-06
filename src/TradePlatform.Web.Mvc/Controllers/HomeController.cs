using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TradePlatform.Controllers;

namespace TradePlatform.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TradePlatformControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
