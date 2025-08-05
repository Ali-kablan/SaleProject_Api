using SaleProject.Entities;

namespace SaleProject.Repository
{
    public interface ISaleInvoiceRepository : IGenericRepository<SaleInvoice>
    {
        // Method to get a sale invoice with customer and products
        Task<SaleInvoice?> GetByIdWithDetailsAsync(string id);
        Task<IEnumerable<SaleInvoice>> GetAllWithDetailsAsync();
        // Method to get invoices by customer
        Task<IEnumerable<SaleInvoice>> GetByCustomerIdAsync(string customerId);
    }
}