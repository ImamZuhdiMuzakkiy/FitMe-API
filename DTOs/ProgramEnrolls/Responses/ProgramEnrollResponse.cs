namespace FitMe.API.DTOs.ProgramEnrolls.Responses;

public record ProgramEnrollResponse
(
    Guid ProgramEnrollId,
    Guid WorkoutProgramId,
    string ProgramTitle,
    StatusProgramEnroll Status,
    DateTime StartDate,
    DateTime? EndDate
);
