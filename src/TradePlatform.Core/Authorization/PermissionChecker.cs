using Abp.Authorization;
using TradePlatform.Authorization.Roles;
using TradePlatform.Authorization.Users;

namespace TradePlatform.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
