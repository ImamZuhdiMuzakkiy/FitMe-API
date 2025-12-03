using FitMe.API.DTOs.Users.Requests;

namespace FitMe.API.Services.Interfaces;

public interface IUserService
{
    Task<string> LoginAsync(LoginRequest request, CancellationToken cancellationToken);
}
