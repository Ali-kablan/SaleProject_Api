namespace SaleProject.Entities
{
    public class Customer
    {
        public string? Id { get; set; }

        // Navigation property to its dedicated contact info
        public virtual CustomerContactInfo ContactInfo { get; set; }

        public virtual ICollection<SaleInvoice> SaleInvoices { get; set; }
    }
}
