namespace SaleProject.DTOs.Product_DTOs
{
    public class CreateProductDto
    {

        // DTO for creating/updating a product
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SalePrice { get; set; }
        public decimal BuyPrice { get; set; }
    }
}
