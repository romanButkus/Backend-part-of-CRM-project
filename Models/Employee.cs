using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public decimal Salary { get; set; }

        public int OutletId { get; set; }
        public Outlet Outlet { get; set; } = new();
    }
}
