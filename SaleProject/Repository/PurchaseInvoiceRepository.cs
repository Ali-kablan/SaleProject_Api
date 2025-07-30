using Microsoft.EntityFrameworkCore;
using SaleProject.DataAccess;
using SaleProject.Entities;

namespace SaleProject.Repository
{
    public class PurchaseInvoiceRepository : GenericRepository<PurchaseInvoice>, IPurchaseInvoiceRepository
    {
        public PurchaseInvoiceRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<PurchaseInvoice?> GetByIdWithDetailsAsync(string id)
        {
            return await _context.PurchaseInvoices
                .Include(pi => pi.Supplier)
                    .ThenInclude(s => s.ContactInfo)
                .Include(pi => pi.PurchaseInvoiceProduct)
                    .ThenInclude(pip => pip.Product)
                .FirstOrDefaultAsync(pi => pi.Id == id);
        }

        public async Task<IEnumerable<PurchaseInvoice?>> GetAllWithDetailsAsync()
        {
            return await _context.PurchaseInvoices
                .Include(pi => pi.Supplier)
                    .ThenInclude(s => s.ContactInfo)
                .Include(pi => pi.PurchaseInvoiceProduct)
                    .ThenInclude(pip => pip.Product)
                .ToListAsync();
        }

        public async Task<IEnumerable<PurchaseInvoice?>> GetBySupplierIdAsync(string supplierId)
        {
            return await _context.PurchaseInvoices
                .Include(pi => pi.PurchaseInvoiceProduct)
                    .ThenInclude(pip => pip.Product)
                .Where(pi => pi.SupplierId == supplierId)
                .ToListAsync();
        }
    }
}