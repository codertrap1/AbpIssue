using System.Threading.Tasks;
using Abp.Application.Services;
using SpeedTest.Authorization.Accounts.Dto;

namespace SpeedTest.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
