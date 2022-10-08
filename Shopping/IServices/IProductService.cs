using System;
using Shopping.DTOs;
using Shopping.Models;

namespace Shopping.IServices
{
    public interface IProductService
    {
        public Task<List<ProductResponseDTO>> GetProducts();
        public Task<ProductResponseDTO> GetProductById(Guid id);
    }
}

