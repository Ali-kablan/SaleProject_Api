namespace SaleProject.Entities
{
    public class SupplierContactInfo : BaseEntity
    {
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
