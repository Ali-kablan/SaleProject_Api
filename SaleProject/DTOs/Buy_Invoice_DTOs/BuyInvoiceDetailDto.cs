namespace SaleProject.DTOs.Invoice_DTOs
{
    // DTO representing a single line item on a returned invoice
    public class BuyInvoiceDetailDto
    {
        public string ProductName { get; set; } // Flattened data: easier for the client
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
