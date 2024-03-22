namespace SalesApp.Models
{
    public class ProductSale
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public double SalePrice { get; set; }
        public int SaleQty { get; set; }
        public required string SaleDate { get; set; }
    }
}
