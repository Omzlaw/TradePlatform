using System;
using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.Referrals.DTO
{
    public class CreateReferralDto
    {
        [Required]
        public string ClientName { get; set; }
        [Required]
        public string RefLevel { get; set; }
        [Required]
        public string Parent { get; set; }
        [Required]
        public string ClientStatus { get; set; }
        [Required]
        public DateTime DateRegistered { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}