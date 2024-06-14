using Kolokwium_s22884.Exceptions;
using Kolokwium_s22884.ResponseModels;
using Kolokwium_s22884.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium_s22884.Controllers;


[Route("api/characters")]
[ApiController]
public class CharacterController
{
    private IService _service;

    public CharacterController(IService service)
    {
        _service = service;
    }

    [HttpGet("{characterId:int}")]
    public async Task<IActionResult> GetCharacterbyId(int characterId)
    {
        return (IActionResult)Results.Ok(await _service.GetCharacterByIdAsync(characterId));
    }
    
    [HttpPost("{characterId}/backpackslots")]
    public async Task<ActionResult> AddItemsToBackpack(int characterId, [FromBody] AddItemsToBackpack dto)
    {
        var (success, message) = await _service.AddItemsToBackpackAsync(characterId, dto.ItemIds);

        if (!success)
        {
            throw new BadRequestException("Nie ma nic");
        }

        return (ActionResult)Results.Ok(message);
    }
}