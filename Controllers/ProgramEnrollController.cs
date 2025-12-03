using FitMe.API.DTOs.ProgramEnrolls.Responses;
using FitMe.API.Services.Interfaces;
using FitMe.API.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace FitMe.API.Controllers;

[ApiController]
[Route("api/enrollments")]
public class ProgramEnrollController : ControllerBase
{
    private readonly IProgramEnrollService _programEnrollService;

    public ProgramEnrollController(IProgramEnrollService programEnrollService)
    {
        _programEnrollService = programEnrollService;
    }

    [HttpGet("/me")]
    public async Task<IActionResult> GetAll(Guid userId, CancellationToken cancellationToken)
    {
        var data = await _programEnrollService.GetMyEnrollmentsAsync(userId, cancellationToken);
        return Ok(new ApiResponse<IEnumerable<ProgramEnrollListItemResponse>>(data, "Success"));
    }

    [HttpPut("{enrollmentId}/complete")]
    public async Task<IActionResult> PutComplete(Guid enrollmentId, CancellationToken cancellationToken)
    {
        await _programEnrollService.CompleteEnrollmentAsync(enrollmentId, cancellationToken);
        return Ok(new ApiResponse<object>("Workout Program Completed"));
    }
}
