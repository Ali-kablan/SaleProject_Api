namespace SaleProject.Entities
{
    using System;
    using System.Collections.Generic;

    public class SaleInvoice
    {
        public int Id { get; set; } // Primary Key
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Foreign Key to Customer
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } // Navigation property to the single customer

        // Navigation property to the details of this invoice
        public ICollection<SaleInvoiceDetail> SaleInvoiceDetails { get; set; }
    }
}
