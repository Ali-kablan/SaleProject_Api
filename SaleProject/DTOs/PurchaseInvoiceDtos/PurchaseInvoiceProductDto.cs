using SaleProject.DTOs.ProductDtos;

namespace SaleProject.DTOs.Invoice_DTOs
{
    public class PurchaseInvoiceProductDto
    {

        public string ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
