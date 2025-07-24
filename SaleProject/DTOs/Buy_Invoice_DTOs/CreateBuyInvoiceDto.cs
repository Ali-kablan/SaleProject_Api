namespace SaleProject.DTOs.Invoice_DTOs
{
    // DTO for CREATING a new purchase invoice
    public class CreateBuyInvoiceDto
    {
        public int SupplierId { get; set; }
        public DateTime InvoiceDate { get; set; }
        // A list of products being purchased
        public ICollection<BuyInvoiceProductDto> Products { get; set; }
    }
}