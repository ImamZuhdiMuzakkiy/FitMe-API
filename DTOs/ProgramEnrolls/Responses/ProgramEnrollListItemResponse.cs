namespace FitMe.API.DTOs.ProgramEnrolls.Responses;

public record ProgramEnrollListItemResponse
(
    Guid ProgramEnrollId,
    string ProgramTitle,
    StatusProgramEnroll Status,
    DateTime StartDate,
    DateTime? EndDate
);
