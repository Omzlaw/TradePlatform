using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.Withdrawals
{
    public interface IWithdrawalManager : IDomainService
    {
        Task<IEnumerable<Withdrawal>> GetWithdrawalsByUserProfile(int userProfileId);
        Task<IEnumerable<Withdrawal>> GetWithdrawalsByReceivingMode(int receivingModeId);
    }
}