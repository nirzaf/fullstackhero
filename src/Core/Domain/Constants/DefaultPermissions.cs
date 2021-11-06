using System.Collections.Generic;

namespace DN.WebApi.Domain.Constants
{
    public static class DefaultPermissions
    {
        public static List<string> Basics => new List<string>()
        {
            PermissionConstants.Products.Search,
            PermissionConstants.Products.View,
            PermissionConstants.Brands.Search,
            PermissionConstants.Brands.View
        };
    }
}