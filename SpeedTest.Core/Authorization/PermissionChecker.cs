using Abp.Authorization;
using SpeedTest.Authorization.Roles;
using SpeedTest.Authorization.Users;

namespace SpeedTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
