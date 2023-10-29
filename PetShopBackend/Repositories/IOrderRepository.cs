using PetShopBackend.models;

public interface IOrderRepository
{
    void PlaceOrder(List<OrderItem> orderItems);

}