using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.Countries.DTO
{
    public class CountryListDto : EntityDto<int>
    {
        public string Name { get; set; }
        
        
    }
}