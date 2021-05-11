using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using TradePlatform.Application.TradeInvestment.MiscellaneousTransactions.DTO;
using TradePlatform.Authorization;
using TradePlatform.Core.TradeInvestment;
using TradePlatform.Core.TradeInvestment.MiscellaneousTransactions;

namespace TradePlatform.Application.TradeInvestment.MiscellaneousTransactions
{
    [AbpAuthorize(PermissionNames.Pages_MiscellaneousTransactions)]
    public class MiscellaneousTransactionAppService : AsyncCrudAppService<MiscellaneousTransaction, MiscellaneousTransactionDto, int, MiscellaneousTransactionListDto, CreateMiscellaneousTransactionDto, EditMiscellaneousTransactionDto>, IMiscellaneousTransactionAppService
    {
        private readonly IMiscellaneousTransactionManager _miscellaneousTransactionManager;
        private readonly IMapper _mapper;
        public MiscellaneousTransactionAppService(IRepository<MiscellaneousTransaction, int> repository, IMiscellaneousTransactionManager miscellaneousTransactionManager, IMapper mapper) : base(repository)
        {
            _miscellaneousTransactionManager = miscellaneousTransactionManager;
            _mapper = mapper;
        }

        public async Task<ListResultDto<MiscellaneousTransactionListDto>> GetMiscellaneousTransactionsByInvestmentPlan(int investmentPlanId)
        {
            var dep = await _miscellaneousTransactionManager.GetMiscellaneousTransactionsByInvestmentPlan(investmentPlanId);
            return new ListResultDto<MiscellaneousTransactionListDto>(_mapper.Map<List<MiscellaneousTransactionListDto>>(dep));
        }

        public async Task<ListResultDto<MiscellaneousTransactionListDto>> GetMiscellaneousTransactionsByPackage(int packageId)
        {
            var dep = await _miscellaneousTransactionManager.GetMiscellaneousTransactionsByPackage(packageId);
            return new ListResultDto<MiscellaneousTransactionListDto>(_mapper.Map<List<MiscellaneousTransactionListDto>>(dep));
        }

        public async Task<ListResultDto<MiscellaneousTransactionListDto>> GetMiscellaneousTransactionsByUserProfile(int userProfileId)
        {
            var dep = await _miscellaneousTransactionManager.GetMiscellaneousTransactionsByUserProfile(userProfileId);
            return new ListResultDto<MiscellaneousTransactionListDto>(_mapper.Map<List<MiscellaneousTransactionListDto>>(dep));
        }
    }
}