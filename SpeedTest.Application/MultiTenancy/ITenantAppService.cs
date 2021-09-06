using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SpeedTest.MultiTenancy.Dto;

namespace SpeedTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
