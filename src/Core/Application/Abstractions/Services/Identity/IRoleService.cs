using DN.WebApi.Application.Wrapper;
using DN.WebApi.Shared.DTOs.Identity;
using DN.WebApi.Shared.DTOs.Identity.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DN.WebApi.Application.Abstractions.Services.Identity
{
    public interface IRoleService : ITransientService
    {
        Task<Result<List<RoleDto>>> GetListAsync();

        Task<Result<List<PermissionDto>>> GetPermissionsAsync(string id);

        Task<int> GetCountAsync();

        Task<Result<RoleDto>> GetByIdAsync(string id);

        Task<Result<string>> RegisterRoleAsync(RoleRequest request);

        Task<Result<string>> DeleteAsync(string id);

        Task<Result<List<RoleDto>>> GetUserRolesAsync(string userId);
        Task<Result<string>> UpdatePermissionsAsync(string id, List<UpdatePermissionsRequest> request);
    }
}