using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using JahomProject.Configuration.Dto;

namespace JahomProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : JahomProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
