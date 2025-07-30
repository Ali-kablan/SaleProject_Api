namespace SaleProject.Entities
{
    public class Customer : BaseEntity
    {
        public string? Name { get; set; }
        public string? Note { get; set; }
       
        public virtual ICollection<CustomerContactInfo> ContactInfo { get; set; } = [];
        public virtual ICollection<SaleInvoice> SaleInvoices { get; set; } = [];
    }
}
