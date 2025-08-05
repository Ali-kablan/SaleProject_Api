using SaleProject.Entities;

namespace SaleProject.Repository
{

    public interface ISupplierRepository : IGenericRepository<Supplier>
    {
        // Method to get a Supplier AND their contact info
        Task<Supplier?> GetByIdWithContactAsync(string id);
        Task<IEnumerable<Supplier?>> GetAllWithContactAsync();
    }

}
