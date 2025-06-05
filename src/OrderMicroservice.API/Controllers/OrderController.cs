using Microsoft.AspNetCore.Mvc;
using OrderMicroservice.API.Dtos.Reuests;
using OrderMicroservice.Application.Commands;
using OrderMicroservice.Application.Interfaces;

namespace OrderMicroservice.API.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;
    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }
    [HttpPost(WebRoutes.Create)]
    public async Task<IActionResult> CreateOrderAsync([FromBody] CreateOrderRequest request, CancellationToken cancellationToken = default)
    {
        var command = new CreateOrderCommand
        {
            UserId = request.UserId
        };

        var orderId = _orderService.CreateBookingAsync(command, cancellationToken);
        return Ok(new { OrderId = orderId });
    }
    [HttpPost(WebRoutes.Cancel)]
    public async Task<IActionResult> CancelOrderAsync(long id, CancellationToken cancellationToken = default)
    {
        var command = new CancelOrderCommand { OrderId = id };
        await _orderService.CancelBookingAsync(command, cancellationToken);
        return NoContent();
    }
}