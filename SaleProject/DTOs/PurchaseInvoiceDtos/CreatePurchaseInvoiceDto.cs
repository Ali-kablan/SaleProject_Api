namespace SaleProject.DTOs.Invoice_DTOs
{
    public class CreatePurchaseInvoiceDto
    {
        public int SupplierId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<PurchaseInvoiceProductDto> Products { get; set; }
    }
}
