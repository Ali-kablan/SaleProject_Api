using SaleProject.DTOs.SupplierDtos;

namespace SaleProject.DTOs.SupplierDtos
{
    public class SupplierDto :BaseDtos
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Note { get; set; }  
        public ICollection<SupplierContactInfoDto> ContactInfo { get; set; } = [];
    }
}
