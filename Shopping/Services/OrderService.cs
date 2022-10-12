using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Shopping.Data;
using Shopping.DTOs;
using Shopping.Entites;
using Shopping.IServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Shopping.Services
{
    public class OrderService : IOrderService
    {
        public readonly DataContext _db;
        public readonly IMapper _mapper;
        public OrderService(DataContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task AddOrder(OrderAddRequestDTO model)
        {
            Order order = _mapper.Map<Order>(model);
            var orderId = await _db.Orders.AsNoTracking().CountAsync();
            order.OrderId = $"#{orderId++}";
            List<Product> products = await _db.Products.Where(x => model.OrderDetails.Select(y => y.ProductId).Contains(x.Id)).ToListAsync();
            foreach (var item in order.OrderDetails)
            {
                var product = products.Find(x => x.Id == item.ProductId);
                if (product != null)
                {
                    item.Price = product.Price;
                    item.SKU = product.SKU;
                    order.Total += item.Quantity * product.Price;
                }
            }

            await _db.Orders.AddAsync(order);
            await _db.SaveChangesAsync();
        }

        public async Task<OrderResponseDTO> GetOrderById(Guid orderId)
        {
            var order = await _db.Orders.Where(x => x.Id == orderId)
                                        .Include(x => x.OrderDetails)
                                        .ThenInclude(x => x.Product)
                                        .ThenInclude(x => x.Category)
                                        .Include(x=>x.OrderDetails)
                                        .ThenInclude(x =>x.Product)
                                        .ThenInclude(x=>x.ProductImages)
                                        .Include(x => x.OrderDetails)
                                        .ThenInclude(x => x.Product)
                                        .ThenInclude(x => x.ProductChoices)
                                        .ThenInclude(x=>x.Choice)
                                        .ThenInclude(x=>x.ChoiceCategory)
                                        .Include(x => x.OrderDetails)
                                        .ThenInclude(x => x.Product)
                                        .ThenInclude(x=>x.ProductInformations)
                                        .SingleOrDefaultAsync();
            if (order == null)
            {
                throw new KeyNotFoundException("order not found");
            }
            return _mapper.Map<OrderResponseDTO>(order);
        }

        public async Task<List<OrderResponseDTO>> getOrdersByUserId(Guid userId)
        {
            var orders = await _db.Orders.Where(x => x.AppUserId == userId)
                                        .Include(x => x.OrderDetails)
                                        .ThenInclude(x => x.Product)
                                        .ThenInclude(x => x.Category)
                                        .Include(x => x.OrderDetails)
                                        .ThenInclude(x => x.Product)
                                        .ThenInclude(x => x.ProductImages)
                                        .Include(x => x.OrderDetails)
                                        .ThenInclude(x => x.Product)
                                        .ThenInclude(x => x.ProductChoices)
                                        .ThenInclude(x => x.Choice)
                                        .ThenInclude(x => x.ChoiceCategory)
                                        .Include(x => x.OrderDetails)
                                        .ThenInclude(x => x.Product)
                                        .ThenInclude(x => x.ProductInformations)
                                        .ToListAsync();
            return _mapper.Map<List<OrderResponseDTO>>(orders);
        }
    }
}

