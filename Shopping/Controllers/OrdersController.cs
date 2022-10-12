using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopping.DTOs;
using Shopping.IServices;
using Shopping.Extensions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shopping.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly IOrderService orderService;

        public OrdersController(IOrderService orderService)
        {
            this.orderService = orderService;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<OrderResponseDTO>> GetOrderById(Guid id)
        {
            return await orderService.GetOrderById(id);
        }


        [HttpGet("me")]
        public async Task<ActionResult<List<OrderResponseDTO>>> GetUserOrders()
        {
            return await orderService.getOrdersByUserId(User.GetUserId());
        }

        [HttpPost]
        public async Task<ActionResult> AddOrder(OrderAddRequestDTO model)
        {
            if (User.Identity != null)
            {
                if (User.Identity.IsAuthenticated)
                {
                    model.AppUserId = User.GetUserId();
                }
            }
            await orderService.AddOrder(model);
            return Ok();
        }

    }
}

