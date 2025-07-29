using SaleProject.DTOs;
using SaleProject.DTOs.User_DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SaleProject.Services.User
{
    public interface  IUserService
    {
        public Task<IEnumerable<UserDto>> GetAllUsersAsync();

       /// fdsfsf
    }
}
