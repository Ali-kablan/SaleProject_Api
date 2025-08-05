namespace SaleProject.Entities
{
    public class SaleInvoiceProducts : BaseEntity
    {
        public string SaleInvoiceId { get; set; } // Foreign Key to SaleInvoice
        public SaleInvoice SaleInvoice { get; set; }

        public string ProductId { get; set; } // Foreign Key to Product
        public Product Product { get; set; }

        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; } // Price at the time of sale
    }
}
