using Kabutar.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Kabutar.Service.Dtos;

public class VerifyEmailDto
{
    [Required(ErrorMessage = "Email is required"), Email]
    public string Email { get; set; } = string.Empty;

    [Required]
    public int Code { get; set; }
}
