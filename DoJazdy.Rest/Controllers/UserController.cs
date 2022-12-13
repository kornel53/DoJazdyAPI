using DoJazdy.Application;
using DoJazdy.Application.Services;
using DoJazdy.Core.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DoJazdy.Rest.Controllers;

[ApiController]
[Route("/users/")]
public class UserController : ControllerBase
{
	private readonly IUserService _userService;

	public UserController(IUserService userService)
	{
		_userService = userService;
	}
	
	[HttpPost("login")]
	public async Task<ActionResult<Guid>> Login(UserLoginDTO userLoginDto)
	{
		var userId = await _userService.LoginUser(userLoginDto);
		if (userId == Guid.Empty)
		{
			return Unauthorized();
		}
		
		return Ok(userId);
	}

	[HttpPost("register")]
	public async Task<ActionResult> Register(User user)
	{
		if (await _userService.RegisterUser(user))
		{
			return Ok();
		}

		return BadRequest();
	}
}