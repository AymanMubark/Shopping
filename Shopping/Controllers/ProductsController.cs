using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shopping.DTOs;
using Shopping.IServices;
using Shopping.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shopping.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductResponseDTO>>  GetProductById(Guid id)
        {
            return await productService.GetProductById(id);
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductResponseDTO>>> GetProducts()
        {
            return await productService.GetProducts();
        }

    }
}

