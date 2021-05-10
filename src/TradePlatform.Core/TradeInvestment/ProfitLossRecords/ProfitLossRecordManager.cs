using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.ProfitLossRecords
{
    public class ProfitLossRecordManager : DomainService, IProfitLossRecordManager
    {
        private readonly IRepository<ProfitLossRecord, int> _profitLossRecordRepository;
        public ProfitLossRecordManager(IRepository<ProfitLossRecord, int> profitLossRecordRepository)
        {
            _profitLossRecordRepository = profitLossRecordRepository;
        }

        public async Task<IEnumerable<ProfitLossRecord>> GetProfitLossRecordsByInvestmentPlan(int investmentPlanId)
        {
            return await _profitLossRecordRepository.GetAllListAsync(p => p.InvestmentPlanId == investmentPlanId); 
        }

        public async Task<IEnumerable<ProfitLossRecord>> GetProfitLossRecordsByUserProfile(int userProfileId)
        {
            return await _profitLossRecordRepository.GetAllListAsync(d => d.UserProfileId == userProfileId); 
        }
    }
}