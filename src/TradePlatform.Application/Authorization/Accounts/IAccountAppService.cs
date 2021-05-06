using System.Threading.Tasks;
using Abp.Application.Services;
using TradePlatform.Authorization.Accounts.Dto;

namespace TradePlatform.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
