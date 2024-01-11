using Microsoft.AspNetCore.Mvc;
using StarWarsApp_API.Services;

[ApiController]
[Route("[controller]")]
public class StarWarsController : ControllerBase
{
    private readonly StarWarsService _starWarsService;

    public StarWarsController(StarWarsService starWarsService)
    {
        _starWarsService = starWarsService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCharacters()
    {
        try
        {
            var result = await _starWarsService.GetCharactersAsync();
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCharacterDetail(int id)
    {
        try
        {
            var result = await _starWarsService.GetCharacterDetailAsync(id);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("search")]
    public async Task<IActionResult> Search([FromQuery] string name)
    {
        try
        {
            var result = await _starWarsService.SearchCharactersAsync(name);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
