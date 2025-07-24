namespace SaleProject.Entities
{
    public class BuyInvoiceDetail
    {
        public string Id { get; set; }  =Guid.CreateVersion7().ToString();

        public int BuyInvoiceId { get; set; } // Foreign Key to BuyInvoice
        public BuyInvoice BuyInvoice { get; set; }

        public int ProductId { get; set; } // Foreign Key to Product
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; } // Price at the time of purchase
    }
}
