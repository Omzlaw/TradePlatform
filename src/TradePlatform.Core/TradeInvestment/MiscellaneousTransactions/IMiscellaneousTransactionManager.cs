using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.MiscellaneousTransactions
{
    public interface IMiscellaneousTransactionManager : IDomainService
    {
        Task<IEnumerable<MiscellaneousTransaction>> GetMiscellaneousTransactionsByUserProfile(int userProfileId);
        Task<IEnumerable<MiscellaneousTransaction>> GetMiscellaneousTransactionsByInvestmentPlan(int investmentPlanId);
        Task<IEnumerable<MiscellaneousTransaction>> GetMiscellaneousTransactionsByPackage(int packageId);
    }
}