using SaleProject.Entities;

namespace SaleProject.Repository
{
    public interface ICustomerContactInfoRepository : IGenericRepository<CustomerContactInfo>
    {
        // Method to get contact info by customer ID
        Task<IEnumerable<CustomerContactInfo?>> GetByCustomerIdAsync(string customerId);
        // Method to get contact info with customer details
        Task<CustomerContactInfo?> GetByIdWithCustomerAsync(string id);
    }
}