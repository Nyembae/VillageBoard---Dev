using Abp.Authorization;
using Villageboard.Authorization.Roles;
using Villageboard.Authorization.Users;

namespace Villageboard.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
