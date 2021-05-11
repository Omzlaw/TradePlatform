using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using TradePlatform.Application.TradeInvestment.Countries.DTO;
using TradePlatform.Authorization;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Countries
{
    [AbpAuthorize(PermissionNames.Pages_Countries)]
    public class CountryAppService : AsyncCrudAppService<Country, CountryDto, int, CountryListDto, CreateCountryDto, EditCountryDto>, ICountryAppService
    {
        public CountryAppService(IRepository<Country> repository)
        : base(repository)
        {

        }
    }
}