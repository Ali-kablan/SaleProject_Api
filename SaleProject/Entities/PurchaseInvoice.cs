namespace SaleProject.Entities
{
    using System;
    using System.Collections.Generic;

    public class PurchaseInvoice
    {
        public int Id { get; set; } // Primary Key
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Foreign Key to Supplier
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; } // Navigation property to the single supplier

        // Navigation property to the details of this invoice
        public virtual ICollection<PurchaseInvoiceProducts> PurchaseInvoiceProduct { get; set; } = [];  // BALTU NOTE // Initialize to an empty collection to avoid null reference issues
    }
}
