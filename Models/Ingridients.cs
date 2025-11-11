namespace Menu.Models
{
    public class Ingridients
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<DishIngredient>? DishIngredients { get; set; }

    }
}
