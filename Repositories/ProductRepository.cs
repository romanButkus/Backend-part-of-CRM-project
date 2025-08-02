using backend.Data.Context;
using backend.Models;

namespace backend.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(AppDbContext context)
            : base(context) { }
    }
}
