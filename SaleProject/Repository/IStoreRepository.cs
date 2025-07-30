using SaleProject.Entities;

namespace SaleProject.Repository
{
    public interface IStoreRepository : IGenericRepository<Store>
    {
        // Method to get a store with its stock information
        Task<Store?> GetByIdWithStockAsync(string id);
        Task<IEnumerable<Store?>> GetAllWithStockAsync();
    }
}