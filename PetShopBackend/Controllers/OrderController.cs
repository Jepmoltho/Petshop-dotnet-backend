using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using PetShopBackend.models;

public class OrderController : ControllerBase {

    private OrderService _orderService;
    private PetService _petService; 

    public OrderController(PetService petservice, OrderService orderservice){
        _orderService = orderservice;
        _petService = petservice;
    }

    /*
    YOU GOT TO HERE
    [HttpPost("placeOrder")]
    public async Task<IActionResult> PlaceOrderEmployee(List<Item> items){
         var placeOrder = await _orderService.PlaceOrder(List<Item> items);
         return Ok(placedOrder);
     }
     */

    // [HttpPost("placeOrder")]
    // public async Task<IActionResult> PlaceOrderEmployee(int emplyeeId, List<Item> items){
    //     var placeOrder = await _orderService
    // }

}