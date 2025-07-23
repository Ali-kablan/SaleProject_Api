using SaleProject.DTOs.Product_DTOs;
using SaleProject.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaleProject.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _productRepository;

        // We inject the generic repository for the Product entity
        public ProductService(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();
            // Manually map entities to DTOs
            var productDtos = new List<ProductDto>();
            foreach (var product in products)
            {
                productDtos.Add(new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    SalePrice = product.SalePrice
                });
            }
            return productDtos;
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) return null;

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                SalePrice = product.SalePrice
            };
        }

        public async Task<ProductDto> CreateProductAsync(CreateProductDto createProductDto)
        {
            // Map DTO to Entity
            var product = new Product
            {
                Name = createProductDto.Name,
                Description = createProductDto.Description,
                SalePrice = createProductDto.SalePrice,
                BuyPrice = createProductDto.BuyPrice
            };

            await _productRepository.AddAsync(product);
            await _productRepository.SaveChangesAsync();

            // Map the created entity back to a DTO to return it
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                SalePrice = product.SalePrice
            };
        }

        public async Task<bool> UpdateProductAsync(int id, CreateProductDto createProductDto)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) return false; // Product not found

            // Update properties
            product.Name = createProductDto.Name;
            product.Description = createProductDto.Description;
            product.SalePrice = createProductDto.SalePrice;
            product.BuyPrice = createProductDto.BuyPrice;

            _productRepository.Update(product);
            await _productRepository.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) return false; // Product not found

            _productRepository.Delete(product);
            await _productRepository.SaveChangesAsync();
            return true;
        }
    }
}