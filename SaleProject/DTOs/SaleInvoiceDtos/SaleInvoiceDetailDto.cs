namespace SaleProject.DTOs.Sale_Invoice_DTOs
{
    public class SaleInvoiceProductsDto
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; } // The price the product was sold at
    }
}
