namespace SaleProject.Entities
{
    using System;
    using System.Collections.Generic;

    public class BuyInvoice
    {
        public int Id { get; set; } // Primary Key
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Foreign Key to Supplier
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; } // Navigation property to the single supplier

        // Navigation property to the details of this invoice
        public ICollection<BuyInvoiceDetail> BuyInvoiceDetails { get; set; }
    }
}
