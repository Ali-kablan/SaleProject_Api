namespace SaleProject.Entities
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; } 
        public string? Unit { get; set; } // that is simple way to  detect the product unit 
        public decimal SalePrice { get; set; } // Price you sell at
        public decimal BuyPrice { get; set; }  // Price you buy at

        // Navigation Properties for many-to-many relationships
        public ICollection<StoreStock> StoreStocks { get; set; } = [];
        public ICollection<SaleInvoiceProducts> SaleInvoiceProduct { get; set; } = [];
        public ICollection<PurchaseInvoiceProducts> PurchaseInvoiceProduct { get; set; } = [];
    }
}