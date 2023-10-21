using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PetShopBackend.Data;
using PetShopBackend.models;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class PetsController : ControllerBase
{

    private readonly PetService _petService;
    private readonly ILogger<PetsController> _logger;

    public PetsController(PetService petService, ILogger<PetsController> logger)
    {
        _petService = petService;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pet>>> GetPets()
    {
        var pets = await _petService.GetPets();
        return Ok(pets);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Pet>> GetPet(int id)
    {
        var pet = await _petService.GetPetById(id);
        return Ok(pet);
    }

    [HttpGet("species/{type}")]
    public async Task<ActionResult<IEnumerable<Pet>>> GetPetsByType(string type){
        
        if (string.IsNullOrEmpty(type))
        {
            return BadRequest("Type is required");
        }

        try 
        {
            var pets = await _petService.GetPetsByType(type);
            return Ok(pets);
        } 
        catch (Exception e)
        {
            _logger.LogError(e, "An error occured");
            return StatusCode(500, "An error occured");
        }


    }


    [HttpGet("oldDogs")]
    public async Task<ActionResult<IEnumerable<Pet>>> GetOldDogs()
    {
        var oldDogs = await _petService.GetOldDogs();
        return Ok(oldDogs);
    }
}