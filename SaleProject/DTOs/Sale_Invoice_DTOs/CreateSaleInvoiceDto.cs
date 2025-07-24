namespace SaleProject.DTOs.Sale_Invoice_DTOs
{
    public class CreateSaleInvoiceDto
    {
        public int CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<SaleInvoiceProductDto> Products { get; set; }
    }
}
