using SaleProject.Entities;

namespace SaleProject.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        // Method to get a product with its stock information
        Task<Product?> GetByIdWithStockAsync(string id);
        Task<IEnumerable<Product?>> GetAllWithStockAsync();
        // Method to search products by name
        Task<IEnumerable<Product?>> SearchByNameAsync(string name);
    }
}