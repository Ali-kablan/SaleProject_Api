using SaleProject.Entities;

namespace SaleProject.Repository
{
    public interface ISupplierContactInfoRepository : IGenericRepository<SupplierContactInfo>
    {
        // Method to get contact info by supplier ID
        Task<IEnumerable<SupplierContactInfo?>> GetBySupplierIdAsync(string supplierId);
        // Method to get contact info with supplier details
        Task<SupplierContactInfo?> GetByIdWithSupplierAsync(string id);
    }
}