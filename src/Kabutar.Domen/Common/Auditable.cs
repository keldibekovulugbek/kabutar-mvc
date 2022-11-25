﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Kabutar.Domain.Common;
public class Auditable
{
    [Column("id")]
    public long Id { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}
