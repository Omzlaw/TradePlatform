using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TradePlatform.Application.TradeInvestment.Verifications.DTO;

namespace TradePlatform.Application.TradeInvestment.Verifications
{
    public interface IVerificationAppService : IApplicationService
    {
         Task<VerificationDto> GetVerificationByUserProfile(int userProfileId);
    }
}