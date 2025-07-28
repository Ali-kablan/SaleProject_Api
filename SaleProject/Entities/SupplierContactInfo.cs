namespace SaleProject.Entities
{
    public class SupplierContactInfo
    {
        public string Id { get; set; } = Guid.CreateVersion7().ToString();
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }


        // Foreign Key and Navigation Property back to the Supplier
        public string SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
