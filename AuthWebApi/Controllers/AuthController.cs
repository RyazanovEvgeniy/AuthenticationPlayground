using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using AuthWebApi.Dto;
using AuthWebApi.Entities;
using AuthWebApi.Services.Interfaces;

namespace AuthWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController(IAuthService authService) : ControllerBase
{
    private readonly IAuthService _authService = authService;

    [HttpPost]
    public async Task<ActionResult<User>> Register(UserDto request)
    {
        var response = await _authService.Register(request);
        return Ok(response);
    }

    [HttpPost("login")]
    public async Task<ActionResult<User>> Login(UserDto request)
    {
        var response = await _authService.Login(request);
        if (response.Success)
            return Ok(response);

        return BadRequest(response.Message);
    }

    [HttpGet("/GetWithAdminRole"), Authorize(Roles = "Admin")]
    public ActionResult<string> GetWithAdminRole()
    {
        return Ok("GetWithAdminRole");
    }

    [HttpGet("/GetWithJwt"), Authorize]
    public ActionResult<string> GetWithJwt()
    {
        return Ok("GetWithJwt");
    }

    [HttpGet("/GetWithoutJwt")]
    public ActionResult<string> GetWithoutJwt()
    {
        return Ok("GetWithoutJwt");
    }
}