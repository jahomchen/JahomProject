using Abp.Authorization;
using JahomProject.Authorization.Roles;
using JahomProject.Authorization.Users;

namespace JahomProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
