using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TradePlatform.EntityFrameworkCore
{
    public static class TradePlatformDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TradePlatformDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TradePlatformDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
