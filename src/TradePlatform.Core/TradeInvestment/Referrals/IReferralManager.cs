using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.Referrals
{
    public interface IReferralManager : IDomainService
    {
        Task<IEnumerable<Referral>> GetReferralsByUserProfile(int userProfileId);
    }
}