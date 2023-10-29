

public class OrderService {

    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository){
        orderRepository = _orderRepository;
    }

    

}