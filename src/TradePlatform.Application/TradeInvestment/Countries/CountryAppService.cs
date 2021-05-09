using Abp.Application.Services;
using Abp.Domain.Repositories;
using TradePlatform.Application.TradeInvestment.Countries.DTO;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Countries
{
    public class CountryAppService : AsyncCrudAppService<Country, CountryDto, int, CountryListDto, CreateCountryDto, EditCountryDto>, IApplicationService
    {
        public CountryAppService(IRepository<Country> repository)
        : base(repository)
        {

        }
    }
}