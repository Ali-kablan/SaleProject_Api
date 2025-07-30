using SaleProject.DTOs.ProductDtos;

namespace SaleProject.DTOs.SaleInvoiceDtos
{
    public class SaleInvoiceProductDto
    {
        public string ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
