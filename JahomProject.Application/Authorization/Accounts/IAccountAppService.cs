using System.Threading.Tasks;
using Abp.Application.Services;
using JahomProject.Authorization.Accounts.Dto;

namespace JahomProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
