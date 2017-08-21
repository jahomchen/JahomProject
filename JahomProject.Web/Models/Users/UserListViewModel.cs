using System.Collections.Generic;
using JahomProject.Roles.Dto;
using JahomProject.Users.Dto;

namespace JahomProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}