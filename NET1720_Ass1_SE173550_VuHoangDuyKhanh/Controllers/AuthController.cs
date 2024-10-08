using Microsoft.AspNetCore.Mvc;
using NET1720_Ass1_SE173550_VuHoangDuyKhanh.Database;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly MemberManager _memberManager;

    public AuthController(MemberManager memberManager)
    {
        _memberManager = memberManager;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        var member = _memberManager.Login(request.Username, request.Password);
        if (member == null) return Unauthorized();

        return Ok(new { Token = member});
    }

}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}