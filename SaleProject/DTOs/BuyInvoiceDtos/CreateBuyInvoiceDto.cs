namespace SaleProject.DTOs.Invoice_DTOs
{
    public class CreateBuyInvoiceDto
    {
        public int SupplierId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<BuyInvoiceProductDto> Products { get; set; }
    }
}
