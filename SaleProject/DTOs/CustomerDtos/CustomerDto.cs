using SaleProject.DTOs.CustomerDtos;

namespace SaleProject.DTOs.Customer_DTOs
{
    public class CustomerDto : BaseDtos
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Note { get; set; }
        public ICollection<CustomerContactInfoDto> ContactInfo { get; set; } = [];
    }
}
