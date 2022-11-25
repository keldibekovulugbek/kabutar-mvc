using Kabutar.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kabutar.Domain.Entities;

[Table("blogs")]
public class Blog : Auditable
{
    [Column("title")]
    public string Title { get; set; } = string.Empty;

    [Column("description")]
    public string Description { get; set; } = string.Empty;

    [Column("image_path")]
    public string ImagePath { get; set; } = string.Empty;

    [Column("user_id")]
    public long UserId { get; set; }
    public virtual User User { get; set; } = null!;
}
