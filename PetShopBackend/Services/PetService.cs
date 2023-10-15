using PetShopBackend.models;

public class PetService
{
    private readonly IPetRepository _petRepository;

    public PetService(IPetRepository petRepository)
    {
        _petRepository = petRepository;
    }

    public async Task<Pet> GetPetById(int id)
    {
        var pet = await _petRepository.GetPetById(id);
        return pet;
    }

    public async Task<List<Pet>> GetPets()
    {
        var pets = await _petRepository.GetAllPets();
        return pets; 
    }

    public async Task<List<Pet>> GetOldDogs()
    {
        var pets = await _petRepository.GetAllPets();
        DateTime now = DateTime.Now;
        List<Pet> oldDogs = new List<Pet>();
        foreach (var pet in pets)
        {
            // if (pet.Species == "Dog" && (now - pet.Birthdate).TotalDays > 365*8)
            // {
            //     oldDogs.Add(pet);
            // }
        }
        return oldDogs;

    }
}