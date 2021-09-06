using System.Threading.Tasks;
using Abp.Application.Services;
using SpeedTest.Sessions.Dto;

namespace SpeedTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
