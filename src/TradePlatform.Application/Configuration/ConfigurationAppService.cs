using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TradePlatform.Configuration.Dto;

namespace TradePlatform.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TradePlatformAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
