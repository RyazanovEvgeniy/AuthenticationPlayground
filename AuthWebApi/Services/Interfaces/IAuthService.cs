using AuthWebApi.Dto;
using AuthWebApi.Entities;

namespace AuthWebApi.Services.Interfaces;

public interface IAuthService
{
    Task<User> Register(UserDto request);
    Task<AuthResponseDto> Login(UserDto request);
}
