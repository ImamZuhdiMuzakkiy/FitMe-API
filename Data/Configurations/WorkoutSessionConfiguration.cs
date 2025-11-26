using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class WorkoutSessionConfiguration : IEntityTypeConfiguration<WorkoutSession>
{
    public void Configure(EntityTypeBuilder<WorkoutSession> builder)
    {
        builder.ToTable("tbl_workout_session");
        builder.HasKey(k => k.WorkoutSessionId);

        builder.Property(p => p.WorkoutSessionId).HasColumnName("workout_session_id");
        builder.Property(p => p.WorkoutProgramId).HasColumnName("workout_program_id").IsRequired();
        builder.Property(p => p.Title).HasColumnName("title").HasMaxLength(255).IsRequired();
        builder.Property(p => p.VideoUrl).HasColumnName("video_url").HasMaxLength(500);
        builder.Property(p => p.DurationMinutes).HasColumnName("duration_minutes").HasMaxLength(50);
        builder.Property(p => p.Instructions).HasColumnName("instructions").HasMaxLength(2000);        
    }
}