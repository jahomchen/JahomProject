using System.Threading.Tasks;
using Abp.Application.Services;
using JahomProject.Configuration.Dto;

namespace JahomProject.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}