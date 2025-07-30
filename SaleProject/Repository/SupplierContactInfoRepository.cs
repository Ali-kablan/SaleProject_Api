using Microsoft.EntityFrameworkCore;
using SaleProject.DataAccess;
using SaleProject.Entities;

namespace SaleProject.Repository
{
    public class SupplierContactInfoRepository : GenericRepository<SupplierContactInfo>, ISupplierContactInfoRepository
    {
        public SupplierContactInfoRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<SupplierContactInfo?>> GetBySupplierIdAsync(string supplierId)
        {
            return await _context.SupplierContactInfos
                .Where(si => si.SupplierId == supplierId)
                .ToListAsync();
        }

        public async Task<SupplierContactInfo?> GetByIdWithSupplierAsync(string id)
        {
            return await _context.SupplierContactInfos
                .Include(si => si.Supplier)
                .FirstOrDefaultAsync(si => si.Id == id);
        }
    }
}