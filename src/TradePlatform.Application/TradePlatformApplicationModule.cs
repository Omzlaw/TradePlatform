using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TradePlatform.Authorization;

namespace TradePlatform
{
    [DependsOn(
        typeof(TradePlatformCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TradePlatformApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TradePlatformAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TradePlatformApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
