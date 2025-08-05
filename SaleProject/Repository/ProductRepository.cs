using Microsoft.EntityFrameworkCore;
using SaleProject.DataAccess;
using SaleProject.Entities;

namespace SaleProject.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Product?> GetByIdWithStockAsync(string id)
        {
            return await _context.Products
                .Include(p => p.StoreStocks)
                    .ThenInclude(ss => ss.Store)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product?>> GetAllWithStockAsync()
        {
            return await _context.Products
                .Include(p => p.StoreStocks)
                    .ThenInclude(ss => ss.Store)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product?>> SearchByNameAsync(string name)
        {
            return await _context.Products
                .Where(p => p.Name.Contains(name))
                .ToListAsync();
        }
    }
}