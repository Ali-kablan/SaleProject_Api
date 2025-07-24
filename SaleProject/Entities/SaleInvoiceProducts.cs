namespace SaleProject.Entities
{
    public class SaleInvoiceProducts
    {
        public int Id { get; set; } // Primary Key for this line item

        public int SaleInvoiceId { get; set; } // Foreign Key to SaleInvoice
        public SaleInvoice SaleInvoice { get; set; }

        public int ProductId { get; set; } // Foreign Key to Product
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; } // Price at the time of sale
    }
}
