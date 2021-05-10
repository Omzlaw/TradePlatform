using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TradePlatform.Application.TradeInvestment.MiscellaneousTransactions.DTO;

namespace TradePlatform.Application.TradeInvestment.MiscellaneousTransactions
{
    public interface IMiscellaneousTransactionAppService : IApplicationService
    {
        Task<ListResultDto<MiscellaneousTransactionListDto>> GetMiscellaneousTransactionsByUserProfile(int userProfileId);
        Task<ListResultDto<MiscellaneousTransactionListDto>> GetMiscellaneousTransactionsByInvestmentPlan(int investmentPlanId);
        Task<ListResultDto<MiscellaneousTransactionListDto>> GetMiscellaneousTransactionsByPackage(int packageId);
    }
}