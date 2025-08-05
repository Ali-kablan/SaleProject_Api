using SaleProject.DTOs.SupplierDtos;

namespace SaleProject.DTOs.SupplierDtos
{
    public class CreateSupplierDto
    {
        public string? Name { get; set; }
        public string? Note { get; set; }
        public SupplierContactInfoDto ContactInfo { get; set; } = new SupplierContactInfoDto();
    }
}
