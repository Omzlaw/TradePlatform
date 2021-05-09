using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.Deposits
{
    public interface IDepositManager : IDomainService
    {
        Task<IEnumerable<Deposit>> GetDepositsByUserProfile(int userProfileId);
    }
}