// In Repositories/IGenericRepository.cs
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SaleProject.Repository
{
    public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<int> SaveChangesAsync(); // To commit the transaction
}




}
