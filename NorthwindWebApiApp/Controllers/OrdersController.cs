using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NorthwindWebApiApp.Models;
using NorthwindWebApiApp.Services;

namespace NorthwindWebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BriefOrderDescription>>> GetOrders()
        {
            return Ok(await _orderService.GetOrdersAsync());
        }

        [HttpGet("{orderId}")]
        public async Task<ActionResult<FullOrderDescription>> GetOrder(int orderId)
        {
            return Ok(await _orderService.GetOrderAsync(orderId));
        }
    }
}