using System.Collections.Generic;
using TradePlatform.Roles.Dto;

namespace TradePlatform.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}