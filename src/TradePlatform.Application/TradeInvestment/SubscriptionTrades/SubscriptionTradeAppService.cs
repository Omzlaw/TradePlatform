using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using TradePlatform.Application.TradeInvestment.SubscriptionTrades.DTO;
using TradePlatform.Authorization;
using TradePlatform.Core.TradeInvestment;
using TradePlatform.Core.TradeInvestment.SubscriptionTrades;

namespace TradePlatform.Application.TradeInvestment.SubscriptionTrades
{
    [AbpAuthorize(PermissionNames.Pages_SubscriptionTrades)]
    public class SubscriptionTradeAppService : AsyncCrudAppService<SubscriptionTrade, SubscriptionTradeDto, int, SubscriptionTradeListDto, CreateSubscriptionTradeDto, EditSubscriptionTradeDto>, ISubscriptionTradeAppService
    {
        private readonly ISubscriptionTradeManager _subscriptionTradeManager;
        private readonly IMapper _mapper;
        public SubscriptionTradeAppService(IRepository<SubscriptionTrade, int> repository, ISubscriptionTradeManager subscriptionTradeManager, IMapper mapper) : base(repository)
        {
            _subscriptionTradeManager = subscriptionTradeManager;
            _mapper = mapper;
        }

        public async Task<ListResultDto<SubscriptionTradeListDto>> GetSubscriptionTradesByUserProfile(int userProfileId)
        {
            var dep = await _subscriptionTradeManager.GetSubscriptionTradesByUserProfile(userProfileId);
            return new ListResultDto<SubscriptionTradeListDto>(_mapper.Map<List<SubscriptionTradeListDto>>(dep));
        }
    }
}