namespace SaleProject.Entities
{
    public class Product
    {
        public string Id { get; set; }  = Guid.CreateVersion7().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SalePrice { get; set; } // Price you sell at
        public decimal BuyPrice { get; set; }  // Price you buy at

        // Navigation Properties for many-to-many relationships
        public ICollection<StoreStock> StoreStocks { get; set; } = [];
        public ICollection<SaleInvoiceProducts> SaleInvoiceProduct { get; set; } = [];
        public ICollection<PurchaseInvoiceProducts> PurchaseInvoiceProduct { get; set; } = [];
    }
}
