using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TradePlatform.Configuration;
using TradePlatform.Web;

namespace TradePlatform.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TradePlatformDbContextFactory : IDesignTimeDbContextFactory<TradePlatformDbContext>
    {
        public TradePlatformDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TradePlatformDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TradePlatformDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TradePlatformConsts.ConnectionStringName));

            return new TradePlatformDbContext(builder.Options);
        }
    }
}
