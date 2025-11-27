using FitMe.API.DTOs.ProgramEnrolls.Requests;
using FitMe.API.DTOs.ProgramEnrolls.Responses;

namespace FitMe.API.Services.Interfaces;

public interface IProgramEnrollService
{
    Task EnrollAsync(Guid id, ProgramEnrollRequest request);
    Task<IEnumerable<ProgramEnrollListItemResponse>> GetMyEnrollmentsAsync();
    Task CompleteEnrollmentAsync(Guid id);

}
