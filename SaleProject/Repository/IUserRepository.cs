
using SaleProject.Entities;
namespace SaleProject.Repository
{
    public interface IUserRepository : IGenericRepository<User>
    {
     
        Task<User?> GetByUsernameAsync(string username);
        
        Task<bool> UsernameExistsAsync(string username);
    }
}