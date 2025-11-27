using FitMe.API.DTOs.ProgramWorkouts.Requests;
using FitMe.API.DTOs.ProgramWorkouts.Responses;

namespace FitMe.API.Services.Interfaces;

public interface IWorkoutProgramService
{
    Task CreateProgramWorkoutAsync(ProgramWorkoutRequest request, CancellationToken cancellationToken);
    Task UpdateProgramWorkoutAsync(Guid id, ProgramWorkoutRequest request, CancellationToken cancellationToken);
    Task DeleteProgramWorkoutAsync(Guid id, CancellationToken cancellationToken);

    Task<IEnumerable<ProgramWorkoutResponse>> GetAllProgramWorkoutAsync(CancellationToken cancellantionToken);
    Task<ProgramWorkoutResponse> GetWorkoutProgramByIdAsync(Guid id, CancellationToken cancellationToken); 
}
