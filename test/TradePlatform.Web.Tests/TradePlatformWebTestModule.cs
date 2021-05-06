using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TradePlatform.EntityFrameworkCore;
using TradePlatform.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TradePlatform.Web.Tests
{
    [DependsOn(
        typeof(TradePlatformWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TradePlatformWebTestModule : AbpModule
    {
        public TradePlatformWebTestModule(TradePlatformEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TradePlatformWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TradePlatformWebMvcModule).Assembly);
        }
    }
}