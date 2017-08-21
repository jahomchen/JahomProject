using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JahomProject.MultiTenancy.Dto;

namespace JahomProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
