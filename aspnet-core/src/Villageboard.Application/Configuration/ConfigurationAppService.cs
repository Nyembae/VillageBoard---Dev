using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Villageboard.Configuration.Dto;

namespace Villageboard.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : VillageboardAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
