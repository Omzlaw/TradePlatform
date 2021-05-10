using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.SubscriptionTrades
{
    public class SubscriptionTradeManager : DomainService, ISubscriptionTradeManager
    {
        private readonly IRepository<SubscriptionTrade, int> _subscriptionTradeRepository;
        public SubscriptionTradeManager(IRepository<SubscriptionTrade, int> subscriptionTradeRepository)
        {
            _subscriptionTradeRepository = subscriptionTradeRepository;
        }

        public async Task<IEnumerable<SubscriptionTrade>> GetSubscriptionTradesByUserProfile(int userProfileId)
        {
            return await _subscriptionTradeRepository.GetAllListAsync(d => d.UserProfileId == userProfileId); 
        }
    }
}