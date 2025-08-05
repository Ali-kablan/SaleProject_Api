// In Services/ISupplierService.cs

using SaleProject.DTOs.SupplierDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaleProject.Services.Supplier
{
    public interface ISupplierService
    {
      //  Task<IEnumerable<SupplierDto>> GetAllSuppliersAsync();
        //Task<SupplierDto> GetSupplierByIdAsync(string id);
        //Task<SupplierDto> CreateSupplierAsync(CreateSupplierDto createSupplierDto);
        //Task<bool> UpdateSupplierAsync(string id, CreateSupplierDto createSupplierDto);
        Task<bool> DeleteSupplierAsync(string id);
    }
}