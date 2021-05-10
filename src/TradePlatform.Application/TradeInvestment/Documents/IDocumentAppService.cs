using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TradePlatform.Application.TradeInvestment.Documents.DTO;

namespace TradePlatform.Application.TradeInvestment.Documents
{
    public interface IDocumentAppService : IApplicationService
    {
         Task<ListResultDto<DocumentListDto>> GetDocumentsByUserProfile(int userProfileId);
    }
}