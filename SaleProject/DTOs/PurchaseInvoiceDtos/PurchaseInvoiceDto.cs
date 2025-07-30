using SaleProject.DTOs.Invoice_DTOs;
using SaleProject.DTOs.SupplierDtos;

namespace SaleProject.DTOs.PurchaseInvoiceDtos
{
    public class PurchaseInvoiceDto :BaseDtos
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string SupplierId { get; set; }
        public SupplierDto Supplier { get; set; }
        public ICollection<PurchaseInvoiceDetailDto> Details { get; set; }
    }
}
