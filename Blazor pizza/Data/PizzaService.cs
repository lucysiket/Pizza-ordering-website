using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace Blazor_pizza.Data
{
    public class PizzaService
    {


        // search pizzas
        public async Task<List<Pizza>> GetPizzasSearch(string search, bool vegan, bool vegetarian) /* will only return PizzaService containign search parameter*/
        {
            var queryAbble = dbcontext.Pizzas.AsQueryable();

            if (!string.IsNullOrEmpty(search))  /*if its not empty no parameter is passed */
            {
                queryAbble = queryAbble.Where(p => p.Name.Contains(search));
            }


            if (vegetarian == true)
            {
                queryAbble = queryAbble.Where(p => p.Vegetarian == true);
            }

            if (vegan == true)
            {
                queryAbble = queryAbble.Where(p => p.Vegan == true);
            }


            queryAbble = queryAbble.OrderBy(p => p.Name);

            // Call your data access technology here
            var pizzas = await queryAbble.ToListAsync();
            return pizzas;
        }

        public async Task<Pizza> getPizzabyID(int id)
        {
            var pizza = await dbcontext.Pizzas.FindAsync(id);
            return pizza;
        }

        private readonly ApplicationDBcontext dbcontext;

        public PizzaService(ApplicationDBcontext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

    }    
}
