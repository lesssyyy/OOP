using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.IdentityModel.Tokens;
using QuizApi.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private static List<User> Users = new List<User>();
    private const string Salt = ")GN#447#^nryrETNwrbR%#&NBRE%#%BBDT#%"; // Define the salt here

    public UserController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpPost("Register")]
    public ActionResult Register([FromBody] UserRegisterDto userDto)
    {
        if (Users.Exists(u => u.Username == userDto.Username))
        {
            return BadRequest("Username already exists.");
        }

        // Hash the password and store the user
        var newUser = new User
        {
            Username = userDto.Username,
            Platform = userDto.Platform,
            Password = HashPassword(userDto.Password)
        };

        Users.Add(newUser);
        return Ok("User registered successfully.");
    }

    [HttpPost("Login")]
    public ActionResult Login([FromBody] UserLoginDto userDto)
    {
        // Verify the user and hashed password
        var user = Users.FirstOrDefault(u => u.Username == userDto.Username && u.Password == HashPassword(userDto.Password));
        if (user == null)
        {
            return Unauthorized("Invalid credentials.");
        }

        var token = GenerateJwtToken(user);
        return Ok(new { Token = token, Message = "Login successful." });
    }

    private string GenerateJwtToken(User user)
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Username),
            new Claim("Platform", user.Platform)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: creds);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private string HashPassword(string password)
    {
        using (var md5 = MD5.Create())
        {
            var saltedPassword = Salt + password;
            var hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }
}