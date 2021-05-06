using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TradePlatform.Authorization.Roles;
using TradePlatform.Authorization.Users;
using TradePlatform.MultiTenancy;

namespace TradePlatform.EntityFrameworkCore
{
    public class TradePlatformDbContext : AbpZeroDbContext<Tenant, Role, User, TradePlatformDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TradePlatformDbContext(DbContextOptions<TradePlatformDbContext> options)
            : base(options)
        {
        }
    }
}
