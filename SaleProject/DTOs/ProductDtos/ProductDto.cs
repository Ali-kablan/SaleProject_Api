namespace SaleProject.DTOs.ProductDtos
{
    public class ProductDto :BaseDtos
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SalePrice { get; set; }
        public decimal BuyPrice { get; set; }
    }
}