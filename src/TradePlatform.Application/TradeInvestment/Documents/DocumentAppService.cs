using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using TradePlatform.Application.TradeInvestment.Documents.DTO;
using TradePlatform.Core.TradeInvestment;
using TradePlatform.Core.TradeInvestment.Documents;

namespace TradePlatform.Application.TradeInvestment.Documents
{
    public class DocumentAppService : AsyncCrudAppService<Document, DocumentDto, int, DocumentListDto, CreateDocumentDto, EditDocumentDto>, IDocumentAppService
    {
        private readonly IDocumentManager _documentManager;
        private readonly IMapper _mapper;
        public DocumentAppService(IRepository<Document, int> repository, IDocumentManager documentManager, IMapper mapper) : base(repository)
        {
            _documentManager = documentManager;
            _mapper = mapper;
        }

        public async Task<ListResultDto<DocumentListDto>> GetDocumentsByUserProfile(int userProfileId)
        {
            var dep = await _documentManager.GetDocumentsByUserProfile(userProfileId);
            return new ListResultDto<DocumentListDto>(_mapper.Map<List<DocumentListDto>>(dep));
        }
    }
}