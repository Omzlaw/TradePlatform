using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.Documents.DTO
{
    public class CreateDocumentDto
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