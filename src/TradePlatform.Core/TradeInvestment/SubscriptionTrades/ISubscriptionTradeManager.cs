using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.SubscriptionTrades
{
    public interface ISubscriptionTradeManager : IDomainService
    {
        Task<IEnumerable<SubscriptionTrade>> GetSubscriptionTradesByUserProfile(int userProfileId);
    }
}