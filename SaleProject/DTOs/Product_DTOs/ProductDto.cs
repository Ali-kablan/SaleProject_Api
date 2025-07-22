namespace SaleProject.DTOs.Product_DTOs
{
    public class ProductDto
    {
        // DTO for returning product information
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SalePrice { get; set; }
    }
}
