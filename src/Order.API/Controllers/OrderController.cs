using Microsoft.AspNetCore.Mvc;

namespace Order.API.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Сервис заказов работает.");
    }
}