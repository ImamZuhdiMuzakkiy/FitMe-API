using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProgramEnrollConfiguration : IEntityTypeConfiguration<ProgramEnroll>
{
    public void Configure(EntityTypeBuilder<ProgramEnroll> builder)
    {
        builder.ToTable("tbl_program_enroll");
        builder.HasKey(k => k.ProgramEnrollId);

        builder.Property(p => p.ProgramEnrollId).HasColumnName("program_enroll_id");
        builder.Property(p => p.UserId).HasColumnName("user_id").IsRequired();
        builder.Property(p => p.WorkoutProgramId).HasColumnName("workout_program_id").IsRequired();
        builder.Property(p => p.Status).HasColumnType("varchar(20)").HasColumnName("status").HasConversion<string>().IsRequired();
        builder.Property(p => p.StartDate).HasColumnName("start_date").IsRequired();
        builder.Property(p => p.EndDate).HasColumnName("end_date").IsRequired();
    }
}