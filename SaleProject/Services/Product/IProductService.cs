using SaleProject.DTOs.ProductDtos;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SaleProject.Services.Product
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(string id);
        Task<ProductDto> CreateProductAsync(CreateProductDto createProductDto);
        Task<bool> UpdateProductAsync(string id, CreateProductDto createProductDto);
        Task<bool> DeleteProductAsync(string id);
    }
}
