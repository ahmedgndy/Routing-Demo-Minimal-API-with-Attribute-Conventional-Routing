var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/order/{id:int}", (int id, LinkGenerator link, HttpContext context) =>
{
    //updateOrder this is the endpoint
    // id the rout paramater 
    //context.Request.Scheme http / https 
    // context.Request.Host //localhost:5152
    var editUrl = link.GetUriByName("UpdateOrder" , new {id} ,context.Request.Scheme, context.Request.Host);    
    //order is retrieved 
    return Results.Ok(new
    {
        OrderId = id,
        ProductName = "Sample Product",
        Quantity = 1, 
        _links = new
        {
            self = new { href = context.Request.Path }, 
            edit = new { href = editUrl } 
        }
    });
});

app.MapPut("/order/{id:int}", (int id) =>
{
    //order is updated 

    return Results.Ok();
}).WithName("UpdateOrder");
app.Run();
