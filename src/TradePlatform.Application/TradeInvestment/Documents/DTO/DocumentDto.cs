using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Documents.DTO
{
    [AutoMap(typeof(Document))]
    public class DocumentDto : EntityDto<int>
    {
        public string Type { get; set; }
        public byte[] Content { get; set; }
        public string DocExtension { get; set; }
        public int UserProfileId { get; set; }
    }
}