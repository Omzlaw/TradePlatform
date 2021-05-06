using System.Threading.Tasks;
using Abp.Application.Services;
using TradePlatform.Sessions.Dto;

namespace TradePlatform.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
