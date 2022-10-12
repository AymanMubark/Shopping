using System;
using Shopping.DTOs;
using Shopping.Models;

namespace Shopping.IServices
{
    public interface IProductService
    {
        public Task<PagedList<ProductResponseDTO>> GetProducts(ProductSearchDTO model);
        public Task<ProductResponseDTO> GetProductById(Guid id);
    }
}

