using Microsoft.EntityFrameworkCore;
using SaleProject.DataAccess;
using SaleProject.Entities;

namespace SaleProject.Repository
{
    public class CustomerContactInfoRepository : GenericRepository<CustomerContactInfo>, ICustomerContactInfoRepository
    {
        public CustomerContactInfoRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<CustomerContactInfo?>> GetByCustomerIdAsync(string customerId)
        {
            return await _context.CustomerContactInfos
                .Where(ci => ci.CustomerId == customerId)
                .ToListAsync();
        }

        public async Task<CustomerContactInfo?> GetByIdWithCustomerAsync(string id)
        {
            return await _context.CustomerContactInfos
                .Include(ci => ci.Customer)
                .FirstOrDefaultAsync(ci => ci.Id == id);
        }
    }
}