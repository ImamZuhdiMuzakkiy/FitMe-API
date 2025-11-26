public class WorkoutProgram
{
    public Guid WorkoutProgramId { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DifficultyEnum Difficulty { get; set; }
    public string DurationWeeks { get; set; }
    public StatusWorkoutEnum Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public ICollection<ProgramEnroll>? ProgramEnroll { get; set; }
    public ICollection<WorkoutSession>? WorkoutSession { get; set; }
}

public enum DifficultyEnum
{
    Beginner, Intermediate, Advanced
}

public enum StatusWorkoutEnum
{
    Active, Inactive, Accepted, Rejected
}