using System.Collections.Generic;
using PetShopBackend.Models;

public interface IPetRepository
{
    Task<List<Pet>> GetAllPets();

    Task<Pet> GetPetById(int id);
}