using System.ComponentModel.DataAnnotations;

namespace Kabutar.Service.Dtos
{
    public class AccountLoginDto
    {
        [Required]
        public string EmailOrUsername { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
