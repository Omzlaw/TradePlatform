using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TradePlatform.Controllers
{
    public abstract class TradePlatformControllerBase: AbpController
    {
        protected TradePlatformControllerBase()
        {
            LocalizationSourceName = TradePlatformConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
