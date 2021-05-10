using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.Verifications
{
    public class VerificationManager : DomainService, IVerificationManager
    {
        private readonly IRepository<Verification, int> _verificationRepository;
        public VerificationManager(IRepository<Verification, int> verificationRepository)
        {
            _verificationRepository = verificationRepository;
        }

        public async Task<Verification> GetVerificationByUserProfile(int userProfileId)
        {
            return await _verificationRepository.FirstOrDefaultAsync(d => d.UserProfileId == userProfileId); 
        }
    }
}