using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Countries.DTO
{
    public class CountryMapProfile : Profile
    {
        public CountryMapProfile()
        {
            CreateMap<CreateCountryDto, Country>();
            CreateMap<EditCountryDto, Country>();
            CreateMap<CountryDto, Country>();
            CreateMap<Country, CountryListDto>();
        }
    }
}