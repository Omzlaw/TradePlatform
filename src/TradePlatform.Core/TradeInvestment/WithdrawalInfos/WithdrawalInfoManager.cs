using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.WithdrawalInfos
{
    public class WithdrawalInfoManager : DomainService, IWithdrawalInfoManager
    {
        private readonly IRepository<WithdrawalInfo, int> _withdrawalInfoRepository;
        public WithdrawalInfoManager(IRepository<WithdrawalInfo, int> withdrawalInfoRepository)
        {
            _withdrawalInfoRepository = withdrawalInfoRepository;
        }

        public async Task<IEnumerable<WithdrawalInfo>> GetWithdrawalInfosByUserProfile(int userProfileId)
        {
            return await _withdrawalInfoRepository.GetAllListAsync(d => d.UserProfileId == userProfileId); 
        }
    }
}