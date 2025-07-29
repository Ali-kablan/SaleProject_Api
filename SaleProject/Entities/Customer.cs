namespace SaleProject.Entities
{
    public class Customer
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Note { get; set; }
        // Navigation property to its dedicated contact info
        public virtual ICollection<CustomerContactInfo> ContactInfo { get; set; } = [] ;
        public virtual ICollection<SaleInvoice> SaleInvoices { get; set; } = [];
    }
}
