using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace TradePlatform.Web.Views
{
    public abstract class TradePlatformRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TradePlatformRazorPage()
        {
            LocalizationSourceName = TradePlatformConsts.LocalizationSourceName;
        }
    }
}
