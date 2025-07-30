using SaleProject.Entities;

namespace SaleProject.Repository
{
    public interface IPurchaseInvoiceRepository : IGenericRepository<PurchaseInvoice>
    {
        // Method to get a purchase invoice with supplier and products
        Task<PurchaseInvoice?> GetByIdWithDetailsAsync(string id);
        Task<IEnumerable<PurchaseInvoice?>> GetAllWithDetailsAsync();
        // Method to get invoices by supplier
        Task<IEnumerable<PurchaseInvoice?>> GetBySupplierIdAsync(string supplierId);
    }
}