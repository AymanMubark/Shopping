using System;
using Shopping.DTOs;

namespace Shopping.IServices
{
    public interface ICategoryService
    {
        public Task<List<CategoryResponseDTO>> GetAllCategory(Guid?  parentId);
    }
}

