using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.Documents
{
    public class DocumentManager : DomainService, IDocumentManager
    {
        private readonly IRepository<Document, int> _documentRepository;
        public DocumentManager(IRepository<Document, int> documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public async Task<IEnumerable<Document>> GetDocumentsByUserProfile(int userProfileId)
        {
            return await _documentRepository.GetAllListAsync(d => d.UserProfileId == userProfileId); 
        }
    }
}