using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.MiscellaneousTransactions
{
    public class MiscellaneousTransactionManager : DomainService, IMiscellaneousTransactionManager
    {
        private readonly IRepository<MiscellaneousTransaction, int> _miscellaneousTransactionRepository;
        public MiscellaneousTransactionManager(IRepository<MiscellaneousTransaction, int> miscellaneousTransactionRepository)
        {
            _miscellaneousTransactionRepository = miscellaneousTransactionRepository;
        }

        public async Task<IEnumerable<MiscellaneousTransaction>> GetMiscellaneousTransactionsByInvestmentPlan(int investmentPlanId)
        {
            return await _miscellaneousTransactionRepository.GetAllListAsync(m => m.InvestmentPlanId == investmentPlanId); 
        }

        public async Task<IEnumerable<MiscellaneousTransaction>> GetMiscellaneousTransactionsByPackage(int packageId)
        {
            return await _miscellaneousTransactionRepository.GetAllListAsync(m => m.PackageId == packageId); 
        }

        public async Task<IEnumerable<MiscellaneousTransaction>> GetMiscellaneousTransactionsByUserProfile(int userProfileId)
        {
            return await _miscellaneousTransactionRepository.GetAllListAsync(m => m.UserProfileId == userProfileId); 
        }
    }
}