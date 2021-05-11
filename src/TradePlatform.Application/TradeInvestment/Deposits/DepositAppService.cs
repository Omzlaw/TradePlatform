using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using TradePlatform.Application.TradeInvestment.Deposits.DTO;
using TradePlatform.Authorization;
using TradePlatform.Core.TradeInvestment;
using TradePlatform.Core.TradeInvestment.Deposits;

namespace TradePlatform.Application.TradeInvestment.Deposits
{
    [AbpAuthorize(PermissionNames.Pages_Deposits)]
    public class DepositAppService : AsyncCrudAppService<Deposit, DepositDto, int, DepositListDto, CreateDepositDto, EditDepositDto>, IDepositAppService
    {
        private readonly IDepositManager _depositManager;
        private readonly IMapper _mapper;
        public DepositAppService(IRepository<Deposit, int> repository, IDepositManager depositManager, IMapper mapper) : base(repository)
        {
            _depositManager = depositManager;
            _mapper = mapper;
        }

        public async Task<ListResultDto<DepositListDto>> GetDepositsByUserProfile(int userProfileId)
        {
            var dep = await _depositManager.GetDepositsByUserProfile(userProfileId);
            return new ListResultDto<DepositListDto>(_mapper.Map<List<DepositListDto>>(dep));
        }
    }
}