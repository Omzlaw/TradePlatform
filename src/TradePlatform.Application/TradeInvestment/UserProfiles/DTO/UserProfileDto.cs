using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.UserProfiles.DTO
{
    [AutoMap(typeof(UserProfile))]
    public class UserProfileDto : EntityDto<int>
    {
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public long UserId {get; set;}
    }
}