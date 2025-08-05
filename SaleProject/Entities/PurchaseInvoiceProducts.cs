namespace SaleProject.Entities
{
    public class PurchaseInvoiceProducts : BaseEntity
    {
        public string PurchaseInvoiceId { get; set; } // Foreign Key to PurchaseInvoice
        public PurchaseInvoice PurchaseInvoice { get; set; }

        public string ProductId { get; set; } // Foreign Key to Product
        public Product Product { get; set; }    

        public decimal Quantity { get; set; } // Quantity of the product purchased
        public decimal UnitPrice { get; set; } // Price at the time of purchase
    }
}

