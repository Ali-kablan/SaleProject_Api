
namespace SaleProject.DTOs.SupplierDtos
{
    public class UpdateSupplierDto
    {
        public string? Name { get; set; }
        public string? Note { get; set; }
        public SupplierContactInfoDto? ContactInfo { get; set; }
    }
}