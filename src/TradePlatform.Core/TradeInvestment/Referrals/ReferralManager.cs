using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.Referrals
{
    public class ReferralManager : DomainService, IReferralManager
    {
        private readonly IRepository<Referral, int> _referralRepository;
        public ReferralManager(IRepository<Referral, int> referralRepository)
        {
            _referralRepository = referralRepository;
        }

        public async Task<IEnumerable<Referral>> GetReferralsByUserProfile(int userProfileId)
        {
            return await _referralRepository.GetAllListAsync(d => d.UserProfileId == userProfileId); 
        }
    }
}