using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.Documents.DTO
{
    public class CreateDocumentDto
    {
        [Required]
        public double Amount { get; set;}
        [Required]
        public string Status { get; set;}
        [Required]
        public string PaymentMode { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}