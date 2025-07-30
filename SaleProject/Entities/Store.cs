namespace SaleProject.Entities
{
    public class Store : BaseEntity
    {
        public required string Name { get; set; }
        public string? Location { get; set; }

        // Navigation Property for the many-to-many relationship with Product
        public virtual ICollection<StoreStock> StoreStocks { get; set; }
    }
}

