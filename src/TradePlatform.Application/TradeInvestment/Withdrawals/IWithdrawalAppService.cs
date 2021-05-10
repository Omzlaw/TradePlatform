using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TradePlatform.Application.TradeInvestment.Withdrawals.DTO;

namespace TradePlatform.Application.TradeInvestment.Withdrawals
{
    public interface IWithdrawalAppService : IApplicationService
    {
         Task<ListResultDto<WithdrawalListDto>> GetWithdrawalsByUserProfile(int userProfileId);
         Task<ListResultDto<WithdrawalListDto>> GetWithdrawalsByReceivingMode(int receivingModeId);
    }
}