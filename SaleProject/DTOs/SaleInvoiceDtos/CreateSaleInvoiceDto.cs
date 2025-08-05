using SaleProject.DTOs.SaleInvoiceDtos;

namespace SaleProject.DTOs.Sale_Invoice_DTOs
{
    public class CreateSaleInvoiceDto
    {
        public string CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<SaleInvoiceProductDto> Products { get; set; }
    }
}
