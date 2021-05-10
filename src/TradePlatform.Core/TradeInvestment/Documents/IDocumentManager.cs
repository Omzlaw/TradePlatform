using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.Documents
{
    public interface IDocumentManager : IDomainService
    {
        Task<IEnumerable<Document>> GetDocumentsByUserProfile(int userProfileId);
    }
}