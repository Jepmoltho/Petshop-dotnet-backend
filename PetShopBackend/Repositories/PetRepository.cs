using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using PetShopBackend.Data;
using PetShopBackend.Models;

public class PetRepository : IPetRepository
{
    private readonly PetShopContext _context; 
    public PetRepository(PetShopContext context)
    {   
        _context = context; 
    }

    public async Task<List<Pet>> GetAllPets()
    {
        var pets = await _context.Pets.ToListAsync();
        return pets;
        // return pets;
        // return Ok()
    }

    public async Task<Pet> GetPetById(int id)
    {
        var pet = await _context.Pets.Where(x => x.Id == id).FirstOrDefaultAsync();
        return pet; 
    }

}