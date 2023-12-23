using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly DataContext _context;

    public UsersController(DataContext context)
    {
        _context = context;
    }

    //1) end point
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Entities.AppUser>>> GetUsers()
    {
        //get list of our users
        var users = await _context.Users.ToListAsync();
        return users;

    }

    //2) end point
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        //get list of our users
        return await _context.Users.FindAsync(id);
    }
}
