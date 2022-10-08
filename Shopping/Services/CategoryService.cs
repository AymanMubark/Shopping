using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Shopping.Data;
using Shopping.DTOs;
using Shopping.IServices;

namespace Shopping.Services
{
    public class CategoryService : ICategoryService
    {
        public readonly DataContext _db;
        public readonly IMapper _mapper;
        public CategoryService(DataContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<CategoryResponseDTO>> GetAllCategory()
        {
            var list = await _db.Categories.ToListAsync();
            return _mapper.Map<List<CategoryResponseDTO>>(list);
        }
    }
}

