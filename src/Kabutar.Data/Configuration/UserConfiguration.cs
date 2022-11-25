
using Kabutar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kabutar.Data.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasIndex(user => user.Email).IsUnique();
        builder.HasIndex(user => user.PhoneNumber).IsUnique();
        // create super admin
        // create admin
        // create user
    }
}
