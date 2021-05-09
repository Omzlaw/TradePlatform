using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Countries.DTO
{
    [AutoMapTo(typeof(Country))]
    public class CreateCountryDto
    {
        [Required]
        public string Name { get; set; }
    }
}