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

    
    //We assume list of items contains list of items chosen from the website, that got them frmo the db.  
    // [HttpPost("placeOrder")]
    // public async Task<IActionResult> PlaceOrder(List<Item> items){
    //     try
    //     {
    //      var placeOrder = await _orderService.PlaceOrder(List<Item> items);
    //      return Ok(placedOrder);
    //     } 
    //     catch (Exception ex)
    //     {
    //         return null;
    //     }
    //     return null;
    //  }
     

    // [HttpPost("placeOrder")]
    // public async Task<IActionResult> PlaceOrderEmployee(int emplyeeId, List<Item> items){
    //     var placeOrder = await _orderService
    // }

}