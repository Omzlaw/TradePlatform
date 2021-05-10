
using Abp.Application.Services;
using Abp.Domain.Repositories;
using TradePlatform.Application.TradeInvestment.ReceivingModes.DTO;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.ReceivingModes
{
    public class ReceivingModeAppService : AsyncCrudAppService<ReceivingMode, ReceivingModeDto, int, ReceivingModeListDto, CreateReceivingModeDto, EditReceivingModeDto>, IReceivingModeAppService
    {
        public ReceivingModeAppService(IRepository<ReceivingMode, int> repository) : base(repository)
        {
        }

    }
}