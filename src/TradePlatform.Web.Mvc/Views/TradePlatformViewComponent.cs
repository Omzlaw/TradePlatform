using Abp.AspNetCore.Mvc.ViewComponents;

namespace TradePlatform.Web.Views
{
    public abstract class TradePlatformViewComponent : AbpViewComponent
    {
        protected TradePlatformViewComponent()
        {
            LocalizationSourceName = TradePlatformConsts.LocalizationSourceName;
        }
    }
}
