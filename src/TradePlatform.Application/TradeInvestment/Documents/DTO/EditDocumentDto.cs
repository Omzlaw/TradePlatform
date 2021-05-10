using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Documents.DTO
{
    [AutoMapTo(typeof(Document))]
    public class EditDocumentDto : EntityDto<int>
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public byte[] Content { get; set; }
        [Required]
        public string DocExtension { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}