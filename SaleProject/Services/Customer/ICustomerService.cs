using SaleProject.DTOs.Customer_DTOs;

namespace SaleProject.Services.Customer
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDto>> GetAllCustomersAsync();
        Task<CustomerDto> GetCustomerByIdAsync(string id);
        Task<CustomerDto> CreateCustomerAsync(CreateCustomerDto createCustomerDto);
        Task<bool> UpdateCustomerAsync(string id, CreateCustomerDto createCustomerDto);
        Task<bool> DeleteCustomerAsync(string id);
    }
}
