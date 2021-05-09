using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Countries.DTO
{
    [AutoMapTo(typeof(Country))]
    public class CreateCountryDto
    {
        public string Name { get; set; }
    }
}