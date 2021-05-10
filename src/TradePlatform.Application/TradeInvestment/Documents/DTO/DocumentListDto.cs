using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.Documents.DTO
{
    public class DocumentListDto : EntityDto<int>
    {
        public string Type { get; set; }
        public byte[] Content { get; set; }
        public string DocExtension { get; set; }
        public int UserProfileId { get; set; }
    }
}