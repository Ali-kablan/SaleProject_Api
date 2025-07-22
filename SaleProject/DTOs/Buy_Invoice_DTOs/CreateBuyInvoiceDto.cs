namespace SaleProject.DTOs.Invoice_DTOs
{
    // DTO representing one product line when creating an invoice
    public class BuyInvoiceProductDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; } // Price paid for the product at the time of purchase
    }
}
