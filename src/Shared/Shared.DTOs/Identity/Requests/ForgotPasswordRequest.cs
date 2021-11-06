using System.ComponentModel.DataAnnotations;

namespace DN.WebApi.Shared.DTOs.Identity.Requests
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}