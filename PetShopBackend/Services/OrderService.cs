using PetShopBackend.models;

public class OrderService {

    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository){
        orderRepository = _orderRepository;
    }


    // public async Task<Order> PlaceOrder(List<Item> items){

    //     // foreach

    //     // var items = await _orderRepository.GetItemById();
    // }
}