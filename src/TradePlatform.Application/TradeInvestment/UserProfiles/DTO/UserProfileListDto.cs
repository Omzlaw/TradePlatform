using System;
using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.UserProfiles.DTO
{
    public class UserProfileListDto : EntityDto<int>
    {
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public long UserId {get; set;}
    }
}