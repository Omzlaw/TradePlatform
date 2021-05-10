using System;
using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.UserProfiles.DTO
{
    public class CreateUserProfileDto
    {
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int CountryId { get; set; }
        [Required]
        public long UserId {get; set;}
    }
}