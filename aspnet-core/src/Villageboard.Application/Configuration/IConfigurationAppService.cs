using System.Threading.Tasks;
using Villageboard.Configuration.Dto;

namespace Villageboard.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
