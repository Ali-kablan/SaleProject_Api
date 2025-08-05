using SaleProject.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaleProject.Repository
{
   // public interface IGenericRepository<T> where T : class  // why change from class to BaseEntity? 
    public interface IGenericRepository<T> where T : BaseEntity  // why change from class to BaseEntity? 
    {
        Task<T> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllIncludingDeletedAsync();
        Task AddAsync(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task SoftDelete(T entity);
        Task<int> SaveChangesAsync();

    }
}

