using PetShopBackend.models;

public interface IItemRepository
{
    Task<Item> GetItemById(int id);
}