using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class WorkoutProgramConfiguration : IEntityTypeConfiguration<WorkoutProgram>
{
    public void Configure(EntityTypeBuilder<WorkoutProgram> builder)
    {
        builder.ToTable("tbl_workout_program");
        builder.HasKey(k => k.WorkoutProgramId);

        builder.Property(p => p.WorkoutProgramId).HasColumnName("workout_program_id");
        builder.Property(p => p.UserId).HasColumnName("user_id").IsRequired();
        builder.Property(p => p.Title).HasColumnName("title").HasMaxLength(255).IsRequired();
        builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(1000);
        builder.Property(p => p.Difficulty).HasColumnType("varchar(20)").HasColumnName("difficulty").HasConversion<string>().IsRequired();
        builder.Property(p => p.DurationWeeks).HasColumnName("duration_weeks").HasMaxLength(50).IsRequired();
        builder.Property(p => p.Status).HasColumnType("varchar(20)").HasColumnName("status").HasConversion<string>().IsRequired();
        builder.Property(p => p.CreatedAt).HasColumnName("created_at").IsRequired();
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at").IsRequired();
    }
}