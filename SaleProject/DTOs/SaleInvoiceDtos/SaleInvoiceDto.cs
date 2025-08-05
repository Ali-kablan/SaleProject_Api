using SaleProject.DTOs.Customer_DTOs;
using SaleProject.DTOs.SaleInvoiceDtos;

namespace SaleProject.DTOs.Sale_Invoice_DTOs
{
    public class SaleInvoiceDto :BaseDtos
    {
        public string Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
        public ICollection<SaleInvoiceProductDto> Products { get; set; } = [];
    }
}
