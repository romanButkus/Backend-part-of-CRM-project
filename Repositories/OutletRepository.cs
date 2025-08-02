using backend.Data.Context;
using backend.Models;

namespace backend.Repositories
{
    public class OutletRepository : GenericRepository<Outlet>
    {
        public OutletRepository(AppDbContext context)
            : base(context) { }
    }
}
