using FitMe.API.DTOs.Users.Requests;
using FitMe.API.Services.Interfaces;
using FitMe.API.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace FitMe.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{

    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request, CancellationToken cancellationToken)
    {
        var token = await _userService.LoginAsync(request, cancellationToken);

        return Ok(new ApiResponse<object>(token, "Login Success"));
    }

}
