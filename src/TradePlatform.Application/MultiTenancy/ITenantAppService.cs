using Abp.Application.Services;
using TradePlatform.MultiTenancy.Dto;

namespace TradePlatform.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

