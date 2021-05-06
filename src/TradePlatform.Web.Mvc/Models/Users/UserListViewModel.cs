using System.Collections.Generic;
using TradePlatform.Roles.Dto;

namespace TradePlatform.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
