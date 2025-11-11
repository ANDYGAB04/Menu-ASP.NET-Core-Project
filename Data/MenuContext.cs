using Microsoft.EntityFrameworkCore;
using Menu.Models;

namespace Menu.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(di => new
            {
                di.DishId,
                di.IngredientId
            });
            modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish).WithMany(di => di.DishIngredients).HasForeignKey(d => d.DishId);
            modelBuilder.Entity<DishIngredient>().HasOne(i => i.Ingredient).WithMany(di => di.DishIngredients).HasForeignKey(i => i.IngredientId);

            modelBuilder.Entity<Dish>().HasData(
                new Dish { Id = 1, Name = "Spaghetti Bolognese", ImageUrl = "https://assets.tmecosys.com/image/upload/t_web_rdp_recipe_584x480_1_5x/img/recipe/ras/Assets/d1b38708de15e20816113dc7c447ab99/Derivates/563c08eba9aa94895a39fb0249fecda402d92e28.jpg", Price = 12.99 },
                new Dish { Id = 2, Name = "Caesar Salad", ImageUrl = "https://cdn.loveandlemons.com/wp-content/uploads/2024/12/caesar-salad.jpg", Price = 9.99 }
                );
            modelBuilder.Entity<Ingridients>().HasData(
                new Ingridients { Id = 1, Name = "Spaghetti" },
                new Ingridients { Id = 2, Name = "Ground Beef" },
                new Ingridients { Id = 3, Name = "Tomato Sauce" },
                new Ingridients { Id = 4, Name = "Romaine Lettuce" },
                new Ingridients { Id = 5, Name = "Caesar Dressing" },
                new Ingridients { Id = 6, Name = "Croutons" }
                );
            modelBuilder.Entity<DishIngredient>().HasData(
                new DishIngredient { DishId = 1, IngredientId = 1 },
                new DishIngredient { DishId = 1, IngredientId = 2 },
                new DishIngredient { DishId = 1, IngredientId = 3 },
                new DishIngredient { DishId = 2, IngredientId = 4 },
                new DishIngredient { DishId = 2, IngredientId = 5 },
                new DishIngredient { DishId = 2, IngredientId = 6 }
                );
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingridients> Ingridients { get; set; }

        public DbSet<DishIngredient> DishIngredients { get; set; }
    }
}
