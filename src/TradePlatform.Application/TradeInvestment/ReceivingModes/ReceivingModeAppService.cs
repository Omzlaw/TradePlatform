
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using TradePlatform.Application.TradeInvestment.ReceivingModes.DTO;
using TradePlatform.Authorization;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.ReceivingModes
{
    [AbpAuthorize(PermissionNames.Pages_ReceivingModes)]
    public class ReceivingModeAppService : AsyncCrudAppService<ReceivingMode, ReceivingModeDto, int, ReceivingModeListDto, CreateReceivingModeDto, EditReceivingModeDto>, IReceivingModeAppService
    {
        public ReceivingModeAppService(IRepository<ReceivingMode, int> repository) : base(repository)
        {
        }

    }
}