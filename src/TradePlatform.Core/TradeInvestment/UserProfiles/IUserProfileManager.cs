using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.UserProfiles
{
    public interface IUserProfileManager : IDomainService
    {
        Task<UserProfile> GetUserProfileByUser(int userId);
    }
}