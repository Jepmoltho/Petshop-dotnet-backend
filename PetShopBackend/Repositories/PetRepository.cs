using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using PetShopBackend.Data;
using PetShopBackend.models;

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
    }

    public async Task<Pet> GetPetById(int id)
    {
        var pet = await _context.Pets.Where(x => x.Id == id).FirstOrDefaultAsync();
        return pet; 
    }

    public async Task<List<Pet>> GetPetsByType(string type){
        var pets = await _context.Pets.Where(x => x.Species == type).ToListAsync();
        return pets;
    }

}