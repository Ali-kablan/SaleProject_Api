namespace SaleProject.Entities
{
    public class PurchaseInvoiceProducts
    {
        public string Id { get; set; }  =Guid.CreateVersion7().ToString();

        public int PurchaseInvoiceId { get; set; } // Foreign Key to PurchaseInvoice
        public PurchaseInvoice PurchaseInvoice { get; set; }

        public int ProductId { get; set; } // Foreign Key to Product
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; } // Price at the time of purchase
    }
}
