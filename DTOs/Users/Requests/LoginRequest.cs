namespace FitMe.API.DTOs.Users.Requests;

public record LoginRequest
(
    string Email,
    string Password
);
