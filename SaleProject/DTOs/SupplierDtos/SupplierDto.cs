using SaleProject.DTOs.SupplierDtos;

namespace SaleProject.DTOs.SupplierDtos
{
    public class SupplierDto
    {
        public string Id { get; set; }
        public ICollection<SupplierContactInfoDto> ContactInfo { get; set; } = [];
    }
}
