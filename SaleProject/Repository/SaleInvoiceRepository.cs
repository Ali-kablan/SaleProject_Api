using Microsoft.EntityFrameworkCore;
using SaleProject.DataAccess;
using SaleProject.Entities;

namespace SaleProject.Repository
{
    public class SaleInvoiceRepository : GenericRepository<SaleInvoice>, ISaleInvoiceRepository
    {
        public SaleInvoiceRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<SaleInvoice?> GetByIdWithDetailsAsync(string id)
        {
            return await _context.SaleInvoices
                .Include(si => si.Customer)
                    .ThenInclude(c => c.ContactInfo)
                .Include(si => si.SaleInvoiceProduct)
                    .ThenInclude(sip => sip.Product)
                .FirstOrDefaultAsync(si => si.Id == id);
        }

        public async Task<IEnumerable<SaleInvoice>> GetAllWithDetailsAsync()
        {
            return await _context.SaleInvoices
                .Include(si => si.Customer)
                    .ThenInclude(c => c.ContactInfo)
                .Include(si => si.SaleInvoiceProduct)
                    .ThenInclude(sip => sip.Product)
                .ToListAsync();
        }

        public async Task<IEnumerable<SaleInvoice>> GetByCustomerIdAsync(string customerId)
        {   
            return await _context.SaleInvoices
                .Include(si => si.SaleInvoiceProduct)
                    .ThenInclude(sip => sip.Product)    
                .Where(si => si.CustomerId == customerId)
                .ToListAsync();
        }
    }
}