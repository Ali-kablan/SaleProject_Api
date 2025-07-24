namespace SaleProject.Entities
{
    public class Customer
    {
        public string Id { get; set; }  = Guid.CreateVersion7().ToString();
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }

        // Navigation Property: A Customer can have many SaleInvoices
        public ICollection<SaleInvoice> SaleInvoices { get; set; }
    }
}
