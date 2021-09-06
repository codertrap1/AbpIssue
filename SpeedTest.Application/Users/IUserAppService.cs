using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SpeedTest.Roles.Dto;
using SpeedTest.Users.Dto;

namespace SpeedTest.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}