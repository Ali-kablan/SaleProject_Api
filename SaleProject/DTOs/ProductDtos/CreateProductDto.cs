namespace SaleProject.DTOs.ProductDtos
{
    public class CreateProductDto
    {

        
        public string? Name { get; set; }
        public string? Unit { get; set; }
        public decimal SalePrice { get; set; }
        public decimal BuyPrice { get; set; }
    }
}
