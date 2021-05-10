using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TradePlatform.Application.TradeInvestment.ProfitLossRecordss.DTO;

namespace TradePlatform.Application.TradeInvestment.ProfitLossRecordss
{
    public interface IProfitLossRecordsAppService : IApplicationService
    {
         Task<ListResultDto<ProfitLossRecordsListDto>> GetProfitLossRecordssByUserProfile(int userProfileId);
         Task<ListResultDto<ProfitLossRecordsListDto>> GetProfitLossRecordsByInvestmentPlan(int investmentPlanId);
    }
}