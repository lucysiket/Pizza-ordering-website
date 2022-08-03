using Microsoft.EntityFrameworkCore;

namespace Blazor_pizza.Data
{
    public class PizzaService
    {
        public async Task<List<Pizza>> GetPizzasAsync()
        {
            // Call your data access technology here
            var pizzas = await dbcontext.Pizzas.ToListAsync();
            return pizzas;
        }

        private readonly ApplicationDBcontext dbcontext;

        public PizzaService(ApplicationDBcontext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
    }
}
