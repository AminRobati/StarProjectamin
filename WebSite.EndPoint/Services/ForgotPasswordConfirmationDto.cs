using System.ComponentModel.DataAnnotations;

namespace WebSite.EndPoint.Services
{
    public class ForgotPasswordConfirmationDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
