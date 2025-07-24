namespace SaleProject.DTOs.Sale_Invoice_DTOs
{
    public class SaleInvoiceProductDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        // Note: UnitPrice could be optional here if you always want to use the current price from the Product table
    }

}
