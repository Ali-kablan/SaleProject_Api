using SaleProject.DTOs.CustomerDtos;

namespace SaleProject.DTOs.CustomerDtos
{
    public class UpdateCustomerDto
    {
        public string? Name { get; set; }
        public string? Note { get; set; }
        public CustomerContactInfoDto? ContactInfo { get; set; }
    }
}