namespace SaleProject.Entities
{
    public class Store
    {

        public string Id { get; set; }  = Guid.CreateVersion7().ToString();
        public required string Name { get; set; }
        public string? Location { get; set; }

        // Navigation Property for the many-to-many relationship with Product
        public virtual ICollection<StoreProduct> StoreProducts { get; set; }

    }
}
