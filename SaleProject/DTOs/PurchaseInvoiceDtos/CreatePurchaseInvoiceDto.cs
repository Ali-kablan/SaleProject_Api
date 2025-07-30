using SaleProject.DTOs.Invoice_DTOs;

namespace SaleProject.DTOs.PurchaseInvoiceDtos
{
    public class CreatePurchaseInvoiceDto
    {
        public DateTime InvoiceDate { get; set; }
        public string SupplierId { get; set; }
        public ICollection<PurchaseInvoiceProductDto> Products { get; set; } = [];
    }
}
