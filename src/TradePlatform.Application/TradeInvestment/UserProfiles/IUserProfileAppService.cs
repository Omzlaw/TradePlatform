using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TradePlatform.Application.TradeInvestment.UserProfiles.DTO;

namespace TradePlatform.Application.TradeInvestment.UserProfiles
{
    public interface IUserProfileAppService : IApplicationService
    {
         Task<UserProfileDto> GetUserProfileByUser(int userId);
    }
}