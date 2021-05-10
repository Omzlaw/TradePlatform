using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.WithdrawalInfos
{
    public interface IWithdrawalInfoManager : IDomainService
    {
        Task<IEnumerable<WithdrawalInfo>> GetWithdrawalInfosByUserProfile(int userProfileId);
    }
}