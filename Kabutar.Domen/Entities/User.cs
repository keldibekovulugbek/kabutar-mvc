using Kabutar.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kabutar.Domain.Entities;

[Table("users")]
public class User : Auditable
{
    [Column("first_name")]
    public string FirstName { get; set; } = String.Empty;

    [Column("last_name")]
    public string LastName { get; set; } = String.Empty;

    [Column("username")]
    public string? Username { get; set; }

    [Column("image_path")]
    public string ImagePath { get; set; } = String.Empty;

    [Column("phone_number")]
    public string PhoneNumber { get; set; } = String.Empty;

    [Column("email")]
    public string Email { get; set; } = String.Empty;

    [Column("email_confirmed")]
    public bool EmailConfirmed { get; set; }

    [Column("password_hash")]
    public string PasswordHash { get; set; } = String.Empty;

    [Column("salt")]
    public string Salt { get; set; } = String.Empty;
}
