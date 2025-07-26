namespace SaleProject.Entities
{
    using System.Collections.Generic;

    public class Supplier
    {
        public string? Id { get; set; }

        // Navigation property to its dedicated contact info
        public virtual SupplierContactInfo ContactInfo { get; set; }

        public virtual ICollection<PurchaseInvoice> BuyInvoices { get; set; }
    }
}
