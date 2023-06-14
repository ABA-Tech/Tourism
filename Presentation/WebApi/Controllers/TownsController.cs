namespace WebApi.Controllers;

using Domain.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class TownsController :ControllerBase
{
    private readonly ITownService _townService;

    public TownsController(ITownService context)
    {
        _townService = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TownModel>>> GetTowns()
    {
        return Ok(await _townService.GetTownModels());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TownModel>> GetTown(int id)
    {
        return Ok(await _townService.GetTownModelById(id));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTown(int id, TownModel town)
    {
        if(id != town.Id)
        {
            return BadRequest();
        }

        return Ok(await _townService.UpdateTown(town));
    }

    [HttpPost]
    public async Task<ActionResult<TownModel>> PostTown(TownModel town)
    {
        var result =await _townService.AddTown(town);
        return CreatedAtAction("GetTown", new { id = result }, town);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTown(int id)
    {
        return Ok(await _townService.DeleteTown(id));
    }
}
