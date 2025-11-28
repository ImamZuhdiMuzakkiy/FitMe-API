using FitMe.API.DTOs.ProgramEnrolls.Requests;
using FitMe.API.DTOs.ProgramEnrolls.Responses;

namespace FitMe.API.Services.Interfaces;

public interface IProgramEnrollService
{
    Task EnrollAsync(Guid programId, Guid userId, ProgramEnrollRequest request, CancellationToken cancellationToken);
    Task CompleteEnrollmentAsync(Guid enrollmentId, CancellationToken cancellationToken);
    Task<IEnumerable<ProgramEnrollListItemResponse>> GetMyEnrollmentsAsync(Guid userId, CancellationToken cancellationToken);

}
