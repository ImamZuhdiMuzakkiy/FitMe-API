public class WorkoutSession
{
    public Guid WorkoutSessionId { get; set; }
    public Guid WorkoutProgramId { get; set; }
    public string Title { get; set; }
    public string VideoUrl { get; set; }
    public string DurationMinutes { get; set; }
    public string Instructions { get; set; }
    public WorkoutProgram? WorkoutProgram { get; set; }
}