using System.Collections.Generic;
using PetShopBackend.models;

public interface IPetRepository
{
    Task<List<Pet>> GetAllPets();

    Task<Pet> GetPetById(int id);
}