using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using TradePlatform.Application.TradeInvestment.ProfitLossRecordss.DTO;
using TradePlatform.Core.TradeInvestment;
using TradePlatform.Core.TradeInvestment.ProfitLossRecords;

namespace TradePlatform.Application.TradeInvestment.ProfitLossRecordss
{
    public class ProfitLossRecordsAppService : AsyncCrudAppService<ProfitLossRecord, ProfitLossRecordsDto, int, ProfitLossRecordsListDto, CreateProfitLossRecordsDto, EditProfitLossRecordsDto>, IProfitLossRecordsAppService
    {
        private readonly IProfitLossRecordManager _profitLossRecordsManager;
        private readonly IMapper _mapper;
        public ProfitLossRecordsAppService(IRepository<ProfitLossRecord, int> repository, IProfitLossRecordManager profitLossRecordsManager, IMapper mapper) : base(repository)
        {
            _profitLossRecordsManager = profitLossRecordsManager;
            _mapper = mapper;
        }

        public async Task<ListResultDto<ProfitLossRecordsListDto>> GetProfitLossRecordsByInvestmentPlan(int investmentPlanId)
        {
            var dep = await _profitLossRecordsManager.GetProfitLossRecordsByInvestmentPlan(investmentPlanId);
            return new ListResultDto<ProfitLossRecordsListDto>(_mapper.Map<List<ProfitLossRecordsListDto>>(dep));
        }

        public async Task<ListResultDto<ProfitLossRecordsListDto>> GetProfitLossRecordssByUserProfile(int userProfileId)
        {
            var dep = await _profitLossRecordsManager.GetProfitLossRecordsByUserProfile(userProfileId);
            return new ListResultDto<ProfitLossRecordsListDto>(_mapper.Map<List<ProfitLossRecordsListDto>>(dep));
        }
    }
}