namespace SaleProject.Entities
{
    using System.Collections.Generic;

    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string? Note { get; set; } = string.Empty;
        // Navigation property to its dedicated contact info
        public virtual ICollection<SupplierContactInfo> ContactInfo { get; set; } = [];

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; } = [];
    }
}
