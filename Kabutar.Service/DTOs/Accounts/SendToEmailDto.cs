﻿
using Kabutar.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Kabutar.Service.Dtos;

public class SendToEmailDto
{
    [Required(ErrorMessage = "Email is required"), Email]
    public string Email { get; set; } = string.Empty;
}
