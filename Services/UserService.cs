using System.Security.Claims;
using FitMe.API.DTOs.Users.Requests;
using FitMe.API.Repositories;
using FitMe.API.Repositories.Interfaces;
using FitMe.API.Services.Interfaces;
using FitMe.API.Utilities;

namespace FitMe.API.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    // private readonly IRoleRepository _roleRepository;
    private readonly ITokenHandler _tokenHandler;
    // private readonly IUnitOfWork _unitOfWork;

    public UserService(IUserRepository userRepository, ITokenHandler tokenHandler)
    {
        _userRepository = userRepository;
        // _roleRepository = roleRepository;
        _tokenHandler = tokenHandler;
        // _unitOfWork = unitOfWork;
    }
    // public async Task LoginAsync(LoginRequest request, CancellationToken cancellationToken)
    // {
    //     var user = await _userRepository.GetByEmailAsync(request.Email, cancellationToken);

    //     if (user == null || user.Password != request.Password)
    //         throw new Exception("Invalid email or password");

    //     await _unitOfWork.CommitTransactionAsync(async () =>
    //     {
    //         await _userRepository.UpdateAsync(user);
    //     }, cancellationToken);
    // }

    public async Task<string> LoginAsync(LoginRequest request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByEmailAsync(request.Email, cancellationToken);

        if (user == null || user.Password != request.Password)
            throw new ArgumentException("Invalid email or password");

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Role, user.Role.Name)
        };

        var token = _tokenHandler.Access(claims);

        return token;
    }
}
