using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.ProfitLossRecords
{
    public interface IProfitLossRecordManager : IDomainService
    {
        Task<IEnumerable<ProfitLossRecord>> GetProfitLossRecordsByUserProfile(int userProfileId);
        Task<IEnumerable<ProfitLossRecord>> GetProfitLossRecordsByInvestmentPlan(int investmentPlanId);
    }
}