namespace SaleProject.DTOs.Sale_Invoice_DTOs
{
    public class SaleInvoiceDto
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string CustomerName { get; set; } // Flattened data
        public ICollection<SaleInvoiceProductsDto> Details { get; set; }
    }
}
