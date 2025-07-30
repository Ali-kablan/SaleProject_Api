namespace SaleProject.Entities
{
    public class StoreStock : BaseEntity
    {
        public string StoreId { get; set; }
        public Store Store { get; set; } // if crate storestock you must create store first taht why it is not nullable

        public string ProductId { get; set; } // Foreign Key to Product
        public Product? Product { get; set; }

        public int Quantity { get; set; }  
    }
}
