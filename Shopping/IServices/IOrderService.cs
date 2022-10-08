using System;
using Shopping.DTOs;
namespace Shopping.IServices
{
    public interface IOrderService
    {
        public Task AddOrder(OrderAddRequestDTO model);
    }
}

