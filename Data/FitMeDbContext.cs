using Microsoft.EntityFrameworkCore;

namespace FitMe.API.Data;
public class FitMeDbContext : DbContext
{
    public FitMeDbContext(DbContextOptions<FitMeDbContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<ProgramEnroll> ProgramEnrolls { get; set; }
    public DbSet<WorkoutProgram> WorkoutPrograms { get; set; }

    public DbSet<WorkoutSession> WorkoutSessions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FitMeDbContext).Assembly);

        // modelBuilder.Entity<Role>()
        // .HasOne(u => u.User)
        // .WithMany(r => r.Role)
        // .HasForeignKey(u => u.RoleId)
        // .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<User>()
        .HasOne(u => u.Role)
        .WithMany(r => r.User)
        .HasForeignKey(u => u.RoleId)
        .OnDelete(DeleteBehavior.Restrict);

        // modelBuilder.Entity<User>()
        // .HasMany(u => u.ProgramEnroll)
        // .WithOne(e => e.User)
        // .HasForeignKey(e => e.User);

        modelBuilder.Entity<ProgramEnroll>()
        .HasOne(p => p.User)
        .WithMany(u => u.ProgramEnroll)
        .HasForeignKey(p => p.UserId)
        .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<WorkoutProgram>()
        .HasMany(w => w.ProgramEnroll)
        .WithOne(p => p.WorkoutProgram)
        .HasForeignKey(p => p.WorkoutProgramId)
        .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<WorkoutSession>()
        .HasOne(w => w.WorkoutProgram)
        .WithMany(w => w.WorkoutSession)
        .HasForeignKey(w => w.WorkoutProgramId)
        .OnDelete(DeleteBehavior.Restrict);

        // modelBuilder.Entity<
    }
}