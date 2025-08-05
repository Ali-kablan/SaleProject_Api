namespace SaleProject.Entities
{
    using System;
    using System.Collections.Generic;

    public class SaleInvoice : BaseEntity
    {
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Foreign Key to Customer
        public string CustomerId { get; set; }
        public Customer Customer { get; set; } // Navigation property to the single customer

        // Navigation property to the details of this invoice
        public ICollection<SaleInvoiceProducts> SaleInvoiceProduct { get; set; }
    }
}
