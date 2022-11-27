
using Kabutar.Attributes;
using Kabutar.Domain.Entities;
using Kabutar.Service.Attributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Kabutar.Service.Dtos
{
    public class AccountCreateDto
    {
        [Required, MinLength(3), Name]
        public string Firstname { get; set; } = string.Empty;

        [Required, MinLength(3), Name]
        public string Lastname { get; set; } = string.Empty;

        [PhoneNumber, Required]
        public string PhoneNumber { get; set; } = string.Empty;

        [ Required]
        public string Username { get; set; } = string.Empty;
        [Required, Email]
        public string Email { get; set; } = string.Empty;

        [Required, StrongPassword]
        public string Password { get; set; } = string.Empty;

        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        public IFormFile Image { get; set; } = null!;

        public static implicit operator User(AccountCreateDto accountCreateDto)
        {
            return new User()
            {
                FirstName = accountCreateDto.Firstname,
                LastName = accountCreateDto.Lastname,
                PhoneNumber = accountCreateDto.PhoneNumber,
                Email = accountCreateDto.Email,
                Username = accountCreateDto.Username,
            };
        }
    }
}
