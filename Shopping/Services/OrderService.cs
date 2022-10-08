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
    public class ProductService : IProductService
    {
        public readonly DataContext _db;
        public readonly IMapper _mapper;
        public ProductService(DataContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProductResponseDTO> GetProductById(Guid id)
        {
            Product? product = await _db.Products.Include(x => x.Category)
                         .Include(x => x.ProductImages)
                         .Include(x => x.ProductInformations)
                         .Include(x => x.ProductChoices)
                         .ThenInclude(x => x.Choice)
                         .ThenInclude(x => x.ChoiceCategory)
                         .AsNoTracking()
                         .SingleOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                throw new KeyNotFoundException("product not exist");
            }
            return _mapper.Map<ProductResponseDTO>(product);
        }

        public async Task<List<ProductResponseDTO>> GetProducts()
        {
            var result = await _db.Products.Include(x => x.Category)
                         .Include(x => x.ProductImages)
                         .Include(x => x.ProductInformations)
                         .Include(x=>x.ProductChoices)
                         .ThenInclude(x=>x.Choice)
                         .ThenInclude(x=>x.ChoiceCategory)
                         .AsNoTracking()
                         .ToListAsync();

            return _mapper.Map<List<ProductResponseDTO>>(result);
        }
    }
}

