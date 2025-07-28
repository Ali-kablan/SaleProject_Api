using SaleProject.DTOs.Supplier_DTOs;
using SaleProject.DTOs.SupplierDtos;
using SaleProject.Entities;
using SaleProject.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SaleProject.Services.Supplier
{
    public class SupplierService : ISupplierService
    {
        // We now inject the SPECIFIC repository
        private readonly ISupplierRepository _SupplierRepository;

        public SupplierService(ISupplierRepository SupplierRepository)
        {
            _SupplierRepository = SupplierRepository;
        }

        public async Task<SupplierDto> GetSupplierByIdAsync(string id)
        {
            var Supplier = await _SupplierRepository.GetByIdWithContactAsync(id);
            if (Supplier == null) return null;

            return new SupplierDto
            {
                Id = Supplier.Id,
                ContactInfo = new SupplierContactInfoDto
                {
                    FirstName = Supplier.ContactInfo.FirstName,
                    LastName = Supplier.ContactInfo.LastName,
                    Email = Supplier.ContactInfo.Email,
                    Phone = Supplier.ContactInfo.Phone,
                    City = Supplier.ContactInfo.City
                }
            };
        }

        public async Task<IEnumerable<SupplierDto>> GetAllSuppliersAsync()
        {
            var Suppliers = await _SupplierRepository.GetAllWithContactAsync();
            var dtos = new List<SupplierDto>();
            foreach (var Supplier in Suppliers)
            {
                dtos.Add(new SupplierDto
                {
                    Id = Supplier.Id,
                    ContactInfo = new SupplierContactInfoDto
                    {
                        FirstName = Supplier.ContactInfo.FirstName,
                        LastName = Supplier.ContactInfo.LastName,
                        Email = Supplier.ContactInfo.Email,
                        Phone = Supplier.ContactInfo.Phone,
                        City = Supplier.ContactInfo.City
                    }
                });
            }
            return dtos;
        }

        public async Task<SupplierDto> CreateSupplierAsync(CreateSupplierDto createSupplierDto)
        {
            var Supplier = new SaleProject.Entities.Supplier
            {
                ContactInfo = new SupplierContactInfo // Create the nested object
                {
                    FirstName = createSupplierDto.ContactInfo.FirstName,
                    LastName = createSupplierDto.ContactInfo.LastName,
                    Email = createSupplierDto.ContactInfo.Email,
                    Phone = createSupplierDto.ContactInfo.Phone,
                    City = createSupplierDto.ContactInfo.City
                }
            };

            await _SupplierRepository.AddAsync(Supplier);
            await _SupplierRepository.SaveChangesAsync();

            return await GetSupplierByIdAsync(Supplier.Id); // Reuse get method to return full DTO
        }

        public async Task<bool> UpdateSupplierAsync(string id, CreateSupplierDto createSupplierDto)
        {
            var Supplier = await _SupplierRepository.GetByIdWithContactAsync(id);
            if (Supplier == null) return false;

            // Update the properties of the nested object
            Supplier.ContactInfo.FirstName = createSupplierDto.ContactInfo.FirstName;
            Supplier.ContactInfo.LastName = createSupplierDto.ContactInfo.LastName;
            Supplier.ContactInfo.Email = createSupplierDto.ContactInfo.Email;
            Supplier.ContactInfo.Phone = createSupplierDto.ContactInfo.Phone;
            Supplier.ContactInfo.City = createSupplierDto.ContactInfo.City;

            _SupplierRepository.Update(Supplier);
            await _SupplierRepository.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteSupplierAsync(string id)
        {
            // When you delete a Supplier, EF Core will also delete the associated ContactInfo
            // because of the required one-to-one relationship.
            var Supplier = await _SupplierRepository.GetByIdAsync(id);
            if (Supplier == null) return false;

            _SupplierRepository.Delete(Supplier);
            await _SupplierRepository.SaveChangesAsync();
            return true;
        }
    }
}
