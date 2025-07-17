using Application.DTO;
using Application.IService;
using Microsoft.AspNetCore.Mvc;

namespace InterfaceAdapters.Controller;

[Route("api/role-in-project")]
[ApiController]
public class RoleInProjectController : ControllerBase
{
    private readonly IRoleInProjectService _roleInProjectService;
    List<string> _errorMessages = new List<string>();

    public RoleInProjectController(IRoleInProjectService roleInProjectService)
    {
        _roleInProjectService = roleInProjectService;
    }

    // Post: api/role-in-project
    [HttpPost]
    public async Task<ActionResult<IEnumerable<CreatedRoleInProjectDTO>>> CreateRoleInProject([FromBody] CreateRoleInProjectDTO createRoleInProjectDTO)
    {
        var result = await _roleInProjectService.Create(createRoleInProjectDTO);
        return Ok(result);
    }

    // Put: api/role-in-project/{id}
    [HttpPut("{id}")]
    public async Task<ActionResult<IEnumerable<UpdatedRoleInProjectDTO>>> UpdateRoleInProject(Guid id, [FromBody] UpdateRoleInProjectDTO updateRoleInProjectDTO) {
        var result = await _roleInProjectService.Update(id, updateRoleInProjectDTO);
        return Ok(result);
    }
}
