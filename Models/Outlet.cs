namespace backend.Models
{
    public class Outlet
    {
        public int OutletId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public IEnumerable<Employee> Employers { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
