using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Countries.DTO
{
    [AutoMap(typeof(Country))]
    public class CountryDto : EntityDto<int>
    {
        public string Name { get; set; }
          
    }
}