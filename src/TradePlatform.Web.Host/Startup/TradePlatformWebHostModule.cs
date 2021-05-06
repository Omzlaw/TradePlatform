using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TradePlatform.Configuration;

namespace TradePlatform.Web.Host.Startup
{
    [DependsOn(
       typeof(TradePlatformWebCoreModule))]
    public class TradePlatformWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TradePlatformWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TradePlatformWebHostModule).GetAssembly());
        }
    }
}
