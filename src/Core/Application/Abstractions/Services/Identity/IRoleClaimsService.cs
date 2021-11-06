using DN.WebApi.Application.Wrapper;
using DN.WebApi.Shared.DTOs.Identity.Requests;
using DN.WebApi.Shared.DTOs.Identity.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DN.WebApi.Application.Abstractions.Services.Identity
{
    public interface IRoleClaimsService : ITransientService
    {
        public Task<bool> HasPermissionAsync(string userId, string permission);

        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}