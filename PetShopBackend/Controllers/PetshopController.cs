using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShopBackend.Data;
using PetShopBackend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class PetsController : ControllerBase
{
    // private readonly PetShopContext _context; 
    private readonly IPetRepository _petRepository;

    public PetsController(IPetRepository petRepository)
    {
        // _context = context;
        _petRepository = petRepository;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Pet>> GetPet(int id)
    {
        var pet = await _petRepository.GetPetById(id);
        return Ok(pet);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pet>>> GetPets()
    {
        var pets = await _petRepository.GetAllPets();
        return Ok(pets);
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