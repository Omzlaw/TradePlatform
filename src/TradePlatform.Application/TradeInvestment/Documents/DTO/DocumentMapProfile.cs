using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Documents.DTO
{
    public class DocumentMapProfile : Profile
    {
        public DocumentMapProfile()
        {
            CreateMap<CreateDocumentDto, Document>();
            CreateMap<EditDocumentDto, Document>();
            CreateMap<DocumentDto, Document>();
            CreateMap<Document, DocumentListDto>();
        }
    }
}