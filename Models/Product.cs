namespace backend.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Weight { get; set; }
        public decimal Price { get; set; }

        public int? OutletId { get; set; }
        public Outlet Outlet { get; set; } = new();
    }
}
