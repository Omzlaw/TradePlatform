using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.Verifications
{
    public interface IVerificationManager : IDomainService
    {
        Task<Verification> GetVerificationByUserProfile(int userProfileId);
    }
}