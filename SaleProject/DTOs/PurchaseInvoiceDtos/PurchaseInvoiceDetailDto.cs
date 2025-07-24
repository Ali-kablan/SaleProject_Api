namespace SaleProject.DTOs.Invoice_DTOs
{
  
    public class PurchaseInvoiceDetailDto
    {
        public string ProductName { get; set; } 
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
