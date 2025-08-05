using Microsoft.EntityFrameworkCore;
using SaleProject.DataAccess;
using SaleProject.Entities;

namespace SaleProject.Repository
{

    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Customer?> GetByIdWithContactAsync(string id)
        {
            return await _context.Customers
                .Include(c => c.ContactInfo) // This is the key part!
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Customer?>> GetAllWithContactAsync()
        {
            return await _context.Customers
                .Include(c => c.ContactInfo) // Load related data
                .ToListAsync();
        }
    }



}
