using System;
using Shopping.DTOs;
namespace Shopping.IServices
{
    public interface IOrderService
    {
        public Task AddOrder(OrderAddRequestDTO model);
        public Task<List<OrderResponseDTO>> getOrdersByUserId(Guid userId);
        public Task<OrderResponseDTO> GetOrderById(Guid orderId);
    }
}

