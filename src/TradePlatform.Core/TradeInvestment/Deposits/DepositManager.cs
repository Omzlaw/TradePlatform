using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.Deposits
{
    public class DepositManager : DomainService, IDepositManager
    {
        private readonly IRepository<Deposit, int> _depositRepository;
        public DepositManager(IRepository<Deposit, int> depositRepository)
        {
            _depositRepository = depositRepository;
        }

        public async Task<IEnumerable<Deposit>> GetDepositsByUserProfile(int userProfileId)
        {
            return await _depositRepository.GetAllListAsync(d => d.UserProfileId == userProfileId); 
        }
    }
}