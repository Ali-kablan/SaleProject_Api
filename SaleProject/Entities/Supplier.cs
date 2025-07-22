namespace SaleProject.Entities
{
    using System.Collections.Generic;

    public class Supplier
    {
        public string Id { get; set; } = Guid.CreateVersion7().ToString();
        public string? Name { get; set; }
        public string? ContactPerson { get; set; }
        public string? Email { get; set; }

        // Navigation Property: A Supplier can have many BuyInvoices
        public ICollection<BuyInvoice> BuyInvoices { get; set; }
    }
}
