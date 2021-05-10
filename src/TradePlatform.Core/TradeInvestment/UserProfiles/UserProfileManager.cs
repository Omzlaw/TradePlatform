using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.UserProfiles
{
    public class UserProfileManager : DomainService, IUserProfileManager
    {
        private readonly IRepository<UserProfile, int> _userProfileRepository;
        public UserProfileManager(IRepository<UserProfile, int> userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }


        public async Task<UserProfile> GetUserProfileByUser(int userId)
        {
            return await _userProfileRepository.FirstOrDefaultAsync(d => d.UserId == userId); 
        }
    }
}