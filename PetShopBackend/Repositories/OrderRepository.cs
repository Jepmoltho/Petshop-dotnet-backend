using Microsoft.EntityFrameworkCore;
using PetShopBackend.Data;
using PetShopBackend.models;

public class OrderRepository : IOrderRepository
{

    private PetShopContext _context;
    

    public OrderRepository(PetShopContext context)
    {
        _context = context;
    }

    public void PlaceOrder(List<OrderItem> orderItems)
    {
        // var order = await _context.Add
    }
}