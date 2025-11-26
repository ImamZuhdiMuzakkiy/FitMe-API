using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("tbl_user");
        builder.HasKey(k => k.UserId);

        builder.Property(p => p.UserId).HasColumnName("user_id");
        builder.Property(p => p.RoleId).HasColumnName("role_id").IsRequired();
        builder.Property(p => p.Email).HasColumnName("email").HasMaxLength(255).IsRequired();
        builder.Property(p => p.Password).HasColumnName("password").HasMaxLength(255).IsRequired();
        builder.Property(p => p.Age).HasColumnName("age");
        builder.Property(p => p.Gender).HasColumnType("varchar(10)").HasColumnName("gender").HasConversion<string>().IsRequired();
        builder.Property(p => p.Height).HasColumnName("height");
        builder.Property(p => p.Weight).HasColumnName("weight");
    }
}