using System.Threading.Tasks;
using TradePlatform.Configuration.Dto;

namespace TradePlatform.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
