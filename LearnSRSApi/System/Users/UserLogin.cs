using System.ComponentModel.DataAnnotations;

namespace LearnSRSApi.System.Users
{
    public class UserLogin
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage = "Vui lòng nhập tối thiểu 6 ký tự")]
        public string Password { get; set; } = string.Empty;
    }
}
