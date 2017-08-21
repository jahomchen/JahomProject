using System.Threading.Tasks;
using Abp.Application.Services;
using JahomProject.Sessions.Dto;

namespace JahomProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
