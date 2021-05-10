using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.Withdrawals
{
    public class WithdrawalManager : DomainService, IWithdrawalManager
    {
        private readonly IRepository<Withdrawal, int> _withdrawalRepository;
        public WithdrawalManager(IRepository<Withdrawal, int> withdrawalRepository)
        {
            _withdrawalRepository = withdrawalRepository;
        }

        public async Task<IEnumerable<Withdrawal>> GetWithdrawalsByReceivingMode(int receivingModeId)
        {
            return await _withdrawalRepository.GetAllListAsync(d => d.ReceivingModeId == receivingModeId); 
        }

        public async Task<IEnumerable<Withdrawal>> GetWithdrawalsByUserProfile(int userProfileId)
        {
            return await _withdrawalRepository.GetAllListAsync(d => d.UserProfileId == userProfileId); 
        }
    }
}