using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TradePlatform.Application.TradeInvestment.Deposits.DTO;

namespace TradePlatform.Application.TradeInvestment.Deposits
{
    public interface IDepositAppService : IApplicationService
    {
         Task<ListResultDto<DepositListDto>> GetDepositsByUserProfile(int userProfileId);
    }
}