using FitMe.API.DTOs.ProgramWorkouts.Requests;
using FitMe.API.DTOs.ProgramWorkouts.Responses;

namespace FitMe.API.Services.Interfaces;

public interface IWorkoutProgramService
{
    Task CreateWorkoutProgramAsync(WorkoutProgramRequest request, CancellationToken cancellationToken);
    // Task UpdateWorkoutProgramAsync(Guid id, WorkoutProgramRequest request, CancellationToken cancellationToken);
    Task DeleteWorkoutProgramAsync(Guid id, CancellationToken cancellationToken);

    Task<IEnumerable<WorkoutProgramResponse>> GetAllWorkoutProgramAsync(CancellationToken cancellantionToken);
    Task<WorkoutProgramResponse> GetWorkoutProgramByIdAsync(Guid id, CancellationToken cancellationToken); 
    Task<IEnumerable<WorkoutProgramResponse>> GetPendingProgramsAsync(CancellationToken cancellationToken);
    Task ReviewProgramAsync(Guid id, ProgramReviewRequest request, CancellationToken cancellationToken);
    Task ToggleProgramStatusAsync(Guid id, CancellationToken cancellationToken);

}
