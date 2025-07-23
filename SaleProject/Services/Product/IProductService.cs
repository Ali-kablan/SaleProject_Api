using SaleProject.DTOs.Product_DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SaleProject.Services.Product
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
        Task<ProductDto> CreateProductAsync(CreateProductDto createProductDto);
        Task<bool> UpdateProductAsync(int id, CreateProductDto createProductDto);
        Task<bool> DeleteProductAsync(int id);
    }
}
