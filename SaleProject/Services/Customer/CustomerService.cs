using SaleProject.DTOs.Customer_DTOs;
using SaleProject.DTOs.CustomerDtos;
using SaleProject.Entities;
using SaleProject.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SaleProject.Services.Customer
{
    public class CustomerService : ICustomerService
    {
       
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerDto> GetCustomerByIdAsync(string id)
        {
            var customer = await _customerRepository.GetByIdWithContactAsync(id);
            if (customer == null) return null;

            return new CustomerDto
            {
                Id = customer.Id,
                ContactInfo = new CustomerContactInfoDto
                {
                    FirstName = customer.ContactInfo.FirstName,
                    LastName = customer.ContactInfo.LastName,
                    Email = customer.ContactInfo.Email,
                    Phone = customer.ContactInfo.Phone,
                    City = customer.ContactInfo.City
                }
            };
        }

        public async Task<IEnumerable<CustomerDto>> GetAllCustomersAsync()
        {
            var customers = await _customerRepository.GetAllWithContactAsync();
            var dtos = new List<CustomerDto>();
            foreach (var customer in customers)
            {
                dtos.Add(new CustomerDto
                {
                    Id = customer.Id,
                    ContactInfo = new CustomerContactInfoDto
                    {
                        FirstName = customer.ContactInfo.FirstName,
                        // ... map other properties ...
                    }
                });
            }
            return dtos;
        }

        public async Task<CustomerDto> CreateCustomerAsync(CreateCustomerDto createCustomerDto)
        {
            var customer = new  SaleProject.Entities.Customer
            {
                ContactInfo = new CustomerContactInfo // Create the nested object
                {
                    FirstName = createCustomerDto.ContactInfo.FirstName,
                    LastName = createCustomerDto.ContactInfo.LastName,
                    Email = createCustomerDto.ContactInfo.Email,
                    Phone = createCustomerDto.ContactInfo.Phone,
                    City = createCustomerDto.ContactInfo.City
                }
            };

            await _customerRepository.AddAsync(customer);
            await _customerRepository.SaveChangesAsync();

            return await GetCustomerByIdAsync(customer.Id); // Reuse get method to return full DTO
        }

        public async Task<bool> UpdateCustomerAsync(string id, CreateCustomerDto createCustomerDto)
        {
            var customer = await _customerRepository.GetByIdWithContactAsync(id);
            if (customer == null) return false;

            // Update the properties of the nested object
            customer.ContactInfo.FirstName = createCustomerDto.ContactInfo.FirstName;
            customer.ContactInfo.LastName = createCustomerDto.ContactInfo.LastName;
            customer.ContactInfo.Email = createCustomerDto.ContactInfo.Email;
            customer.ContactInfo.Phone = createCustomerDto.ContactInfo.Phone;
            customer.ContactInfo.City = createCustomerDto.ContactInfo.City;

            _customerRepository.Update(customer);
            await _customerRepository.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCustomerAsync(string id)
        {
            // When you delete a customer, EF Core will also delete the associated ContactInfo
            // because of the required one-to-one relationship.
            var customer = await _customerRepository.GetByIdAsync(id);
            if (customer == null) return false;

            _customerRepository.Delete(customer);
            await _customerRepository.SaveChangesAsync();
            return true;
        }
    }
}
