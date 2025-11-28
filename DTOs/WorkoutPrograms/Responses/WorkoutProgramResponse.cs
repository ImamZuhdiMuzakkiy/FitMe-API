namespace FitMe.API.DTOs.ProgramWorkouts.Responses;

public record WorkoutProgramResponse
(
    Guid ProgramWorkoutId,
    string WorkoutProgramTitle,
    string Description,
    DifficultyEnum Difficulty,
    ushort DurationWeeks,
    StatusWorkoutEnum Status,
    List<WorkoutSessionResponse> Sessions
);

public record WorkoutSessionResponse
(
    Guid WorkoutSessionId,
    string WorkoutSessionTitle,
    string VideoUrl,
    string DurationMinutes,
    string Instructions
);
