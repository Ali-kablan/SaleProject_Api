using Microsoft.EntityFrameworkCore;
using SaleProject.DataAccess;
using SaleProject.Entities;

namespace SaleProject.Repository
{
    public class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Supplier?> GetByIdWithContactAsync(string id)
        {
            return await _context.Suppliers
                .Include(c => c.ContactInfo) // This is the key part!
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Supplier?>> GetAllWithContactAsync()
        {
            return await _context.Suppliers
                .Include(c => c.ContactInfo) // Load related data
                .ToListAsync();
        }
    }

}
