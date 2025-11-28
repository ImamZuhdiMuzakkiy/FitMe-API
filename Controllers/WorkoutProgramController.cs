using FitMe.API.DTOs.ProgramWorkouts.Requests;
using FitMe.API.DTOs.ProgramWorkouts.Responses;
using FitMe.API.Services.Interfaces;
using FitMe.API.Utilities;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/Programs")]
public class WorkoutProgramController : ControllerBase
{
    private readonly IWorkoutProgramService _workoutProgramService;

    public WorkoutProgramController(IWorkoutProgramService workoutProgramService)
    {
        _workoutProgramService = workoutProgramService;
    }

    // MEMBER / PUBLIC
    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken token)
    {
        var data = await _workoutProgramService.GetAllWorkoutProgramAsync(token);
        return Ok(new ApiResponse<IEnumerable<WorkoutProgramResponse>>(data, "Success"));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id, CancellationToken token)
    {
        var data = await _workoutProgramService.GetWorkoutProgramByIdAsync(id, token);
        return Ok(new ApiResponse<WorkoutProgramResponse>(data, "Success"));
    }

    // COACH
    [HttpPost]
    public async Task<IActionResult> Create(WorkoutProgramRequest request, CancellationToken token)
    {
        await _workoutProgramService.CreateWorkoutProgramAsync(request, token);
        return Ok(new ApiResponse<WorkoutProgramResponse>("Workout Program Created"));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id, CancellationToken token)
    {
        await _workoutProgramService.DeleteWorkoutProgramAsync(id, token);
        return Ok(new ApiResponse<WorkoutProgramResponse>("Workout Program Delete"));
    }

    // ADMIN
    [HttpPut("admin/review/{id}")]
    public async Task<IActionResult> Review(Guid id, ProgramReviewRequest request, CancellationToken token)
    {
        await _workoutProgramService.ReviewProgramAsync(id, request, token);
        return Ok(new ApiResponse<object>("Workout Program Review Updated"));
    }

    [HttpPut("admin/toggle-status/{id}")]
    public async Task<IActionResult> ToggleStatus(Guid id, CancellationToken token)
    {
        await _workoutProgramService.ToggleProgramStatusAsync(id, token);
        return Ok(new ApiResponse<object>("Workout Program Status Toggled"));;
    }
}
