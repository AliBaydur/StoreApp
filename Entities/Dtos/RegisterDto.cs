using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record RegisterDto
    {
        [Required(ErrorMessage = "Username is Required")]
        public String? UserName { get; init; }
        [Required(ErrorMessage = "Email is Required")]
        public String? Email { get; init; }
        [Required(ErrorMessage = "Password is Required")]
        public String? Password { get; init; }
    }
}