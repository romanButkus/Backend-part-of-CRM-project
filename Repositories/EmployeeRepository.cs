using backend.Data.Context;
using backend.Models;

namespace backend.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
        public EmployeeRepository(AppDbContext context)
            : base(context) { }
    }
}
