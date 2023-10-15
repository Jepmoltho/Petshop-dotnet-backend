using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShopBackend.Data;
using PetShopBackend.models;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class PetsController : ControllerBase
{
    // private readonly PetShopContext _context; 
    // private readonly IPetRepository _petRepository;
    private readonly PetService _petService;

    // public PetsController(IPetRepository petRepository, PetService petService)

    public PetsController(PetService petService)
    {
        // _context = context;
        // _petRepository = petRepository;
        _petService = petService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Pet>> GetPet(int id)
    {
        var pet = await _petService.GetPetById(id);
        return Ok(pet);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pet>>> GetPets()
    {
        var pets = await _petService.GetPets();
        return Ok(pets);
    }

    [HttpGet("oldDogs")]
    public async Task<ActionResult<IEnumerable<Pet>>> GetOldDogs()
    {
        var oldDogs = await _petService.GetOldDogs();
        return Ok(oldDogs);
    }

    // [HttpGet]
    // public async Task<IActionResult> GetPets()
    // {
    //     var pets = _petRepository.GetAllPets();
    //     return Ok(pets);
    // }

    // [HttpGet("{id}")]
    // public async Task<IActionResult> GetPet(int id)
    // {
    //     var pet = await _petRepository.GetPetById(id);
    //     return Ok(pet);
    // }


    
}