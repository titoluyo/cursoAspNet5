namespace aspnet5.ViewModels.Catalog
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; } = 9.99M;
    }
}
