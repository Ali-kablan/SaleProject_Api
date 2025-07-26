using SaleProject.Entities;

namespace SaleProject.Repository
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        // Method to get a customer AND their contact info
        Task<Customer?> GetByIdWithContactAsync(string id);
        Task<IEnumerable<Customer?>> GetAllWithContactAsync();
    }
}
