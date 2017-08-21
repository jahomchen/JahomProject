using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JahomProject.Roles.Dto;
using JahomProject.Users.Dto;

namespace JahomProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}