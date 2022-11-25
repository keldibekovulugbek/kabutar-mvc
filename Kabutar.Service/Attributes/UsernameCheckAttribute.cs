using System.ComponentModel.DataAnnotations;

namespace Kabutar.Service.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class UsernameCheckAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var username = (string)value!;
        if (!username.Contains("@"))
            return ValidationResult.Success;

        return new ValidationResult($"Cannot use '@' in username");
    }
}
