using SaleProject.DTOs.ProductDtos;
using SaleProject.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaleProject.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<SaleProject.Entities.Product> _productRepository;

        // We inject the generic repository for the Product entity
        public ProductService(IGenericRepository<SaleProject.Entities.Product> productRepository)
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
                    Description = product.Unit,
                    SalePrice = product.SalePrice
                });
            }
            return productDtos;
        }

        public async Task<ProductDto> GetProductByIdAsync(string id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) return null;

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Unit,
                SalePrice = product.SalePrice
            };
        }

        public async Task<ProductDto> CreateProductAsync(CreateProductDto createProductDto)
        {
            // Map DTO to Entity
            var product = new SaleProject.Entities.Product
            {
                Name = createProductDto.Name,
                Unit = createProductDto.Unit,
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
                Description = product.Unit,
                SalePrice = product.SalePrice
            };
        }

        public async Task<bool> UpdateProductAsync(string id, CreateProductDto createProductDto)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) return false; // Product not found

            // Update properties
            product.Name = createProductDto.Name;
            product.Unit = createProductDto.Unit;
            product.SalePrice = createProductDto.SalePrice;
            product.BuyPrice = createProductDto.BuyPrice;

            _productRepository.Update(product);
            await _productRepository.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProductAsync(string id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) return false; // Product not found

            _productRepository.Delete(product);
            await _productRepository.SaveChangesAsync();
            return true;
        }
    }
}