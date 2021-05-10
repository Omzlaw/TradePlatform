using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TradePlatform.Application.TradeInvestment.Referrals.DTO;

namespace TradePlatform.Application.TradeInvestment.Referrals
{
    public interface IReferralAppService : IApplicationService
    {
         Task<ListResultDto<ReferralListDto>> GetReferralsByUserProfile(int userProfileId);
    }
}