using SaleProject.DTOs.CustomerDtos;

namespace SaleProject.DTOs.Customer_DTOs
{
    public class CreateCustomerDto
    {
        public string? Name { get; set; }
        public string? Note { get; set; }
        public CustomerContactInfoDto ContactInfo { get; set; }

    }
}
