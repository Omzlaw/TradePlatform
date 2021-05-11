using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TradePlatform.Authorization.Roles;
using TradePlatform.Authorization.Users;
using TradePlatform.MultiTenancy;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.EntityFrameworkCore
{
    public class TradePlatformDbContext : AbpZeroDbContext<Tenant, Role, User, TradePlatformDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Country> Countries { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<InvestmentPlan> InvestmentPlans { get; set; }
        public DbSet<MiscellaneousTransaction> MiscellaneousTransactions { get; set; }
        public DbSet<Notification> Notification{ get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<ProfitLossRecord> ProfitLossRecords { get; set; }
        public DbSet<ReceivingMode> ReceivingModes { get; set; }
        public DbSet<Referral> Referrals { get; set; }
        public DbSet<SubscriptionTrade> SubscriptionTrades { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Verification> Verifications { get; set; }
        public DbSet<Withdrawal> Withdrawals { get; set; }
        public DbSet<WithdrawalInfo> WithdrawalInfos { get; set; }
        
        public TradePlatformDbContext(DbContextOptions<TradePlatformDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique(true);
            modelBuilder.Entity<InvestmentPlan>().HasIndex(i => i.PlanName).IsUnique(true);
            modelBuilder.Entity<ReceivingMode>().HasIndex(r => r.Type).IsUnique(true);
            modelBuilder.Entity<Referral>().HasIndex(r => r.ClientName).IsUnique(true);
            modelBuilder.Entity<SubscriptionTrade>().HasIndex(s => s.MT4Id).IsUnique(true);
            modelBuilder.Entity<UserProfile>().HasIndex(u => u.PhoneNumber).IsUnique(true);
            modelBuilder.Entity<WithdrawalInfo>().HasIndex(w => w.AccountName).IsUnique(true);
            modelBuilder.Entity<WithdrawalInfo>().HasIndex(w => w.AccountNumber).IsUnique(true);
            modelBuilder.Entity<WithdrawalInfo>().HasIndex(w => w.BTCAddress).IsUnique(true);
            modelBuilder.Entity<WithdrawalInfo>().HasIndex(w => w.LTCAddress).IsUnique(true);
            modelBuilder.Entity<WithdrawalInfo>().HasIndex(w => w.ETHAddress).IsUnique(true);



            modelBuilder.Entity<Deposit>()
            .HasOne(d => d.UserProfile)
            .WithMany(u => u.Deposits)
            .HasForeignKey(d => d.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Document>()
            .HasOne(d => d.UserProfile)
            .WithMany(u => u.Documents)
            .HasForeignKey(d => d.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Document>()
            .HasOne(d => d.UserProfile)
            .WithMany(u => u.Documents)
            .HasForeignKey(d => d.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<MiscellaneousTransaction>()
            .HasOne(d => d.UserProfile)
            .WithMany(u => u.MiscellaneousTransactions)
            .HasForeignKey(d => d.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<MiscellaneousTransaction>()
            .HasOne(m => m.Package)
            .WithMany()
            .HasForeignKey(m => m.PackageId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<MiscellaneousTransaction>()
            .HasOne(m => m.InvestmentPlan)
            .WithMany()
            .HasForeignKey(m => m.PackageId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Notification>()
            .HasOne(n => n.UserProfile)
            .WithMany(u => u.Notifications)
            .HasForeignKey(n => n.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Package>()
            .HasOne(p => p.UserProfile)
            .WithMany(u => u.Packages)
            .HasForeignKey(p => p.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Package>()
            .HasOne(p => p.InvestmentPlan)
            .WithMany()
            .HasForeignKey(p => p.InvestmentPlanId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ProfitLossRecord>()
            .HasOne(p => p.UserProfile)
            .WithMany(u => u.ProfitLossRecords)
            .HasForeignKey(p => p.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ProfitLossRecord>()
            .HasOne(p => p.InvestmentPlan)
            .WithMany()
            .HasForeignKey(p => p.InvestmentPlanId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Referral>()
            .HasOne(p => p.UserProfile)
            .WithMany(u => u.Referrals)
            .HasForeignKey(p => p.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<SubscriptionTrade>()
            .HasOne(p => p.UserProfile)
            .WithMany(u => u.SubscriptionTrades)
            .HasForeignKey(p => p.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Verification>()
            .HasOne(p => p.UserProfile)
            .WithMany()
            .HasForeignKey(p => p.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Withdrawal>()
            .HasOne(p => p.UserProfile)
            .WithMany(u => u.Withdrawals)
            .HasForeignKey(p => p.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Withdrawal>()
            .HasOne(p => p.ReceivingMode)
            .WithMany()
            .HasForeignKey(p => p.ReceivingModeId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<WithdrawalInfo>()
            .HasOne(p => p.UserProfile)
            .WithMany(u => u.WithdrawalInfos)
            .HasForeignKey(p => p.UserProfileId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UserProfile>()
            .HasOne(p => p.User)
            .WithMany()
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UserProfile>()
            .HasOne(p => p.Country)
            .WithMany()
            .HasForeignKey(p => p.CountryId)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
