using System.Collections.Generic;
using TradePlatform.Roles.Dto;

namespace TradePlatform.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
