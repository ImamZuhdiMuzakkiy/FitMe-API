namespace FitMe.API.DTOs.ProgramWorkouts.Requests;

public record WorkoutProgramRequest(
    string WorkoutProgramTitle,
    Guid CoachId,
    string Description,
    DifficultyEnum Difficulty,
    ushort DurationWeeks,
    // StatusWorkoutEnum Status,
    List<WorkoutSessionDTO> Sessions
);

public record WorkoutSessionDTO
(
    string WorkoutSessionTitle,
    string VideoUrl,
    string DurationMinutes,
    string Instructions
);


