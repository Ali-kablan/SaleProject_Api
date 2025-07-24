namespace SaleProject.DTOs.Invoice_DTOs
{
    public class PurchaseInvoiceDto
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string SupplierName { get; set; } // Flattened data
        public ICollection<PurchaseInvoiceDetailDto> Details { get; set; }
    }
}
