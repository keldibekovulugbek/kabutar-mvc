﻿using System.ComponentModel.DataAnnotations;

namespace Kabutar.Service.Dtos
{
    public class EmailMessage
    {
        [Required]
        public string To { get; set; } = string.Empty;

        [Required]
        public string Subject { get; set; } = string.Empty;

        [Required]
        public string Body { get; set; } = string.Empty;
    }
}
