using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Countries.DTO
{
    [AutoMapTo(typeof(Country))]
    public class EditCountryDto : EntityDto
    {
        [Required]
        public string Name { get; set; }
    }
}