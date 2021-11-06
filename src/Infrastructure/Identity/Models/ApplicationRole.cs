using DN.WebApi.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace DN.WebApi.Infrastructure.Identity.Models
{
    public class ApplicationRole : IdentityRole, IIdentityTenant
    {
        public string Description { get; set; }
        public string TenantKey { get; set; }

        public ApplicationRole()
        : base()
        {
        }

        public ApplicationRole(string roleName, string tenantKey, string description = null)
        : base(roleName)
        {
            Description = description;
            NormalizedName = roleName.ToUpper();
            TenantKey = tenantKey;
        }
    }
}