using SaleProject.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaleProject.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity  // why change from class to BaseEntity? 
    {
        Task<T> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllIncludingDeletedAsync();
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SoftDelete(T entity);
        Task<int> SaveChangesAsync();
    }
}

