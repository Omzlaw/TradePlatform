using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using TradePlatform.Application.TradeInvestment.Withdrawals.DTO;
using TradePlatform.Core.TradeInvestment;
using TradePlatform.Core.TradeInvestment.Withdrawals;

namespace TradePlatform.Application.TradeInvestment.Withdrawals
{
    public class WithdrawalAppService : AsyncCrudAppService<Withdrawal, WithdrawalDto, int, WithdrawalListDto, CreateWithdrawalDto, EditWithdrawalDto>, IWithdrawalAppService
    {
        private readonly IWithdrawalManager _withdrawalManager;
        private readonly IMapper _mapper;
        public WithdrawalAppService(IRepository<Withdrawal, int> repository, IWithdrawalManager withdrawalManager, IMapper mapper) : base(repository)
        {
            _withdrawalManager = withdrawalManager;
            _mapper = mapper;
        }

        public async Task<ListResultDto<WithdrawalListDto>> GetWithdrawalsByReceivingMode(int receivingModeId)
        {
            var dep = await _withdrawalManager.GetWithdrawalsByReceivingMode(receivingModeId);
            return new ListResultDto<WithdrawalListDto>(_mapper.Map<List<WithdrawalListDto>>(dep));
        }

        public async Task<ListResultDto<WithdrawalListDto>> GetWithdrawalsByUserProfile(int userProfileId)
        {
            var dep = await _withdrawalManager.GetWithdrawalsByUserProfile(userProfileId);
            return new ListResultDto<WithdrawalListDto>(_mapper.Map<List<WithdrawalListDto>>(dep));
        }
    }
}