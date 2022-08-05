namespace Blazor_pizza.Data
{
    public class BasketItem
    {
        public int PizzaId { get; set; }  // primary key

        public string? Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public BasketItem(int id, string? name, decimal price, int quantity)
        {
            PizzaId = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

    }

    // List of items in the basket
    private List<BasketItem> basket = new List<BasketItem>();




}
