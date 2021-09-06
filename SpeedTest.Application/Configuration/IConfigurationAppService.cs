using System.Threading.Tasks;
using Abp.Application.Services;
using SpeedTest.Configuration.Dto;

namespace SpeedTest.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}