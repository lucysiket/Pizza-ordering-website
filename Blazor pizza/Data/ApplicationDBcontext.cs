using Microsoft.EntityFrameworkCore;

namespace Blazor_pizza.Data
{
    public class ApplicationDBcontext : DbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options)
        : base(options)
        {
        }

        public DbSet<Pizza>? Pizzas => Set<Pizza>();
    }
}
