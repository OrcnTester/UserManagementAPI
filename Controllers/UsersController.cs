using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;
using UserManagementAPI.Services;

namespace UserManagementAPI.Controllers;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    private readonly IUserStore _store;

    public UsersController(IUserStore store)
    {
        _store = store;
    }

    [HttpGet]
    public ActionResult<IEnumerable<User>> GetAll()
        => Ok(_store.GetAll());

    [HttpGet("{id:int}")]
    public ActionResult<User> GetById(int id)
    {
        var user = _store.GetById(id);
        if (user is null) return NotFound(new { error = "User not found." });
        return Ok(user);
    }

    [HttpPost]
    public ActionResult<User> Create([FromBody] User user)
    {
        if (!ModelState.IsValid) return ValidationProblem(ModelState);
        var created = _store.Add(user);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, [FromBody] User user)
    {
        if (!ModelState.IsValid) return ValidationProblem(ModelState);

        var ok = _store.Update(id, user);
        if (!ok) return NotFound(new { error = "User not found." });

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var ok = _store.Delete(id);
        if (!ok) return NotFound(new { error = "User not found." });
        return NoContent();
    }
}
