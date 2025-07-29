namespace SaleProject.Entities
{
    using System.Collections.Generic;

    public class Supplier
    {
        public string? Id { get; set; } = Guid.CreateVersion7().ToString();
        public string? Name { get; set; }
        public string? Note { get; set; }
        // Navigation property to its dedicated contact info
        public virtual ICollection< SupplierContactInfo> ContactInfo { get; set; } = [];

        public virtual ICollection<PurchaseInvoice> PurchaseInvoice { get; set; } = [];
    }
}
