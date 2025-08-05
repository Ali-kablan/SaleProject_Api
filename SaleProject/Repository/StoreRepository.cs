using Microsoft.EntityFrameworkCore;
using SaleProject.DataAccess;
using SaleProject.Entities;

namespace SaleProject.Repository
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        public StoreRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Store?> GetByIdWithStockAsync(string id)
        {
            return await _context.Stores
                .Include(s => s.StoreStocks)
                    .ThenInclude(ss => ss.Product)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<Store?>> GetAllWithStockAsync()
        {
            return await _context.Stores
                .Include(s => s.StoreStocks)
                    .ThenInclude(ss => ss.Product)
                .ToListAsync();
        }
    }
}