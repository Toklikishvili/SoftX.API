using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SoftX.API.Models;
using SoftX.Domain;
using SoftX.Facade.Service;

namespace SoftX.API.Controllers;

[Route("api/v1/user")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService userService;
    private readonly IMapper mapper;

    public UserController(IUserService userService, IMapper mapper)
    {
        this.userService = userService;
        this.mapper = mapper;
    }

    [HttpPost]
    [Route("login")]
    public ActionResult<object> Login(LogInRequest request)
    {
        var response = userService.Login(request.Email, request.Password);
        return Ok(response);
    }

    [HttpPost]
    [Route("register")]
    public ActionResult<object> Register([FromBody] UserModel request)
    {
        if (request == null)
            return BadRequest("request is null");

        return Ok(userService.Register(mapper.Map<User>(request)));
    }
}
