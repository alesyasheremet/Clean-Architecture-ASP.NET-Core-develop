using System.ComponentModel.DataAnnotations;

namespace CustomerData.Domain.Services.Authentication
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
