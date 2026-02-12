using BackendTemplate.Application.Todos;
using Microsoft.AspNetCore.Mvc;

namespace BackendTemplate.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class TodosController(ITodoService todoService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<TodoDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        var todos = await todoService.GetAllAsync(cancellationToken);
        return Ok(todos);
    }
}
