using Microsoft.AspNetCore.Mvc;

namespace _04_Routing_Demo_Minimal_API_with_Attribute_Conventional_Routing.Controllers;

[ApiController]
[Route("orders")]

public class OrdersController : ControllerBase
{
    //get all orders
    [HttpGet]
    public IActionResult GetAllOrders()
    {
        return Ok(new[] { "order1", "order2", "order3" });
    }
}