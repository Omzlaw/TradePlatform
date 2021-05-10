using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TradePlatform.Application.TradeInvestment.WithdrawalInfos.DTO;

namespace TradePlatform.Application.TradeInvestment.WithdrawalInfos
{
    public interface IWithdrawalInfoAppService : IApplicationService
    {
         Task<ListResultDto<WithdrawalInfoListDto>> GetWithdrawalInfosByUserProfile(int userProfileId);
    }
}