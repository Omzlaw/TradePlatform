using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.UserProfiles.DTO
{
    [AutoMapTo(typeof(UserProfile))]
    public class EditUserProfileDto : EntityDto<int>
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