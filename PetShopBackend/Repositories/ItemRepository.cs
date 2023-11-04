using Microsoft.EntityFrameworkCore;
using PetShopBackend.Data;
using PetShopBackend.models;

public class ItemRepository : IItemRepository
{
    private PetShopContext _context;

    public ItemRepository(PetShopContext context){
        _context = context;
    }

    public async Task<Item> GetItemById(int id){
        var item = await _context.Item.Where(x => x.Id == id).FirstOrDefaultAsync();
        return item;
    }

}