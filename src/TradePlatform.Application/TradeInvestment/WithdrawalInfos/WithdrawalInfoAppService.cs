using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using TradePlatform.Application.TradeInvestment.WithdrawalInfos.DTO;
using TradePlatform.Authorization;
using TradePlatform.Core.TradeInvestment;
using TradePlatform.Core.TradeInvestment.WithdrawalInfos;

namespace TradePlatform.Application.TradeInvestment.WithdrawalInfos
{
    [AbpAuthorize(PermissionNames.Pages_WithdrawalInfos)]
    public class WithdrawalInfoAppService : AsyncCrudAppService<WithdrawalInfo, WithdrawalInfoDto, int, WithdrawalInfoListDto, CreateWithdrawalInfoDto, EditWithdrawalInfoDto>, IWithdrawalInfoAppService
    {
        private readonly IWithdrawalInfoManager _withdrawalInfoManager;
        private readonly IMapper _mapper;
        public WithdrawalInfoAppService(IRepository<WithdrawalInfo, int> repository, IWithdrawalInfoManager withdrawalInfoManager, IMapper mapper) : base(repository)
        {
            _withdrawalInfoManager = withdrawalInfoManager;
            _mapper = mapper;
        }

        public async Task<ListResultDto<WithdrawalInfoListDto>> GetWithdrawalInfosByUserProfile(int userProfileId)
        {
            var dep = await _withdrawalInfoManager.GetWithdrawalInfosByUserProfile(userProfileId);
            return new ListResultDto<WithdrawalInfoListDto>(_mapper.Map<List<WithdrawalInfoListDto>>(dep));
        }
    }
}