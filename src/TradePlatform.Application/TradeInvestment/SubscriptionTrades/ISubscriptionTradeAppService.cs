using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TradePlatform.Application.TradeInvestment.SubscriptionTrades.DTO;

namespace TradePlatform.Application.TradeInvestment.SubscriptionTrades
{
    public interface ISubscriptionTradeAppService : IApplicationService
    {
         Task<ListResultDto<SubscriptionTradeListDto>> GetSubscriptionTradesByUserProfile(int userProfileId);
    }
}