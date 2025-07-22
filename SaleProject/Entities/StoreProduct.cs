namespace SaleProject.Entities
{
    public class StoreProduct
    {
        public string StoreId { get; set; } // Foreign Key to Store
        public Store Store { get; set; }

        public int ProductId { get; set; } // Foreign Key to Product
        public Product Product { get; set; }

        public int Quantity { get; set; } // You can add extra data here, like stock quantity
    }
}
