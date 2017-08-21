using Abp.AutoMapper;
using JahomProject.Sessions.Dto;

namespace JahomProject.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}