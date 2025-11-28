public class ProgramEnroll
{
    public Guid ProgramEnrollId { get; set; }
    public Guid UserId { get; set; }
    public Guid WorkoutProgramId { get; set; }
    public StatusProgramEnroll Status { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public WorkoutProgram? WorkoutProgram { get; set; }
    public User? User { get; set; }
}

public enum StatusProgramEnroll
{
    InProgress, Completed
}