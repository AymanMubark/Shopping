using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;
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

        public Task AddOrder(OrderAddRequestDTO model)
        {
            throw new NotImplementedException();
        }
    }
}

