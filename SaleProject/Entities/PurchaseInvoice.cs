namespace SaleProject.Entities
{
    using System;
    using System.Collections.Generic;

    public class PurchaseInvoice : BaseEntity
    {
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Foreign Key to Supplier
        public string SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; } // Navigation property to the single supplier

        // Navigation property to the details of this invoice
        public virtual ICollection<PurchaseInvoiceProducts> PurchaseInvoiceProduct { get; set; } = [];  // BALTU NOTE // Initialize to an empty collection to avoid null reference issues
    }
}
