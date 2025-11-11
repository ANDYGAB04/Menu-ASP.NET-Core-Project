using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Menu.Migrations
{
    /// <inheritdoc />
    public partial class newdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DishIngredients_Ingridients_IngredientId",
                table: "DishIngredients");

            migrationBuilder.DropTable(
                name: "Ingridients");

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 3, "https://www.olivemagazine.com/media/lx4f6n1y/margherita-pizza-1-af-web.jpg", "Margherita Pizza", 14.99 },
                    { 4, "https://images.unsplash.com/photo-1645112411341-6c4ee32510b8?w=600", "Chicken Alfredo", 15.99 },
                    { 5, "https://images.unsplash.com/photo-1562547256-4-4a48e0c01d0?w=600", "Pad Thai", 11.99 },
                    { 6, "https://images.unsplash.com/photo-1579584425555-c3ce17fd4351?w=600", "Sushi Platter", 18.989999999999998 },
                    { 7, "https://images.unsplash.com/photo-1540189549336-e6e99c3679fe?w=600", "Greek Salad", 10.99 },
                    { 8, "https://images.unsplash.com/photo-1565299585323-38d6b0865b47?w=600", "Beef Tacos", 9.9900000000000002 },
                    { 9, "https://images.unsplash.com/photo-1546069901-ba9599a7e63c?w=600", "Grilled Salmon", 19.989999999999998 },
                    { 10, "https://images.unsplash.com/photo-1455619452474-d2be8b1e4e31?w=600", "Vegetable Curry", 12.99 },
                    { 11, "https://images.unsplash.com/photo-1599599810694-a5f1f4d67c6a?w=600", "Lasagna", 13.99 },
                    { 12, "https://images.unsplash.com/photo-1578985545062-69928b1d9587?w=600", "Chocolate Cake", 7.9900000000000002 }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Spaghetti" },
                    { 2, "Ground Beef" },
                    { 3, "Tomato Sauce" },
                    { 4, "Romaine Lettuce" },
                    { 5, "Caesar Dressing" },
                    { 6, "Croutons" },
                    { 7, "Pizza Dough" },
                    { 8, "Fresh Mozzarella" },
                    { 9, "Fresh Basil" },
                    { 10, "Chicken Breast" },
                    { 11, "Alfredo Sauce" },
                    { 12, "Rice Noodles" },
                    { 13, "Fish Sauce" },
                    { 14, "Peanuts" },
                    { 15, "Sushi Rice" },
                    { 16, "Salmon" },
                    { 17, "Nori" },
                    { 18, "Avocado" },
                    { 19, "Feta Cheese" },
                    { 20, "Olives" },
                    { 21, "Cucumber" },
                    { 22, "Tomatoes" },
                    { 23, "Tortillas" },
                    { 24, "Beef" },
                    { 25, "Cheddar Cheese" },
                    { 26, "Sour Cream" },
                    { 27, "Garlic" },
                    { 28, "Lemon Juice" },
                    { 29, "Butter" },
                    { 30, "Coconut Milk" },
                    { 31, "Curry Powder" },
                    { 32, "Spinach" },
                    { 33, "Chocolate" },
                    { 34, "Flour" },
                    { 35, "Eggs" },
                    { 36, "Sugar" },
                    { 37, "Olive Oil" },
                    { 38, "Parmesan Cheese" },
                    { 39, "Onion" },
                    { 40, "Bell Pepper" }
                });

            migrationBuilder.InsertData(
                table: "DishIngredients",
                columns: new[] { "DishId", "IngredientId" },
                values: new object[,]
                {
                    { 1, 38 },
                    { 2, 38 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 37 },
                    { 4, 1 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 38 },
                    { 5, 12 },
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 39 },
                    { 6, 15 },
                    { 6, 16 },
                    { 6, 17 },
                    { 6, 18 },
                    { 7, 4 },
                    { 7, 19 },
                    { 7, 20 },
                    { 7, 21 },
                    { 7, 22 },
                    { 8, 23 },
                    { 8, 24 },
                    { 8, 25 },
                    { 8, 26 },
                    { 9, 16 },
                    { 9, 27 },
                    { 9, 28 },
                    { 9, 37 },
                    { 10, 22 },
                    { 10, 30 },
                    { 10, 31 },
                    { 10, 32 },
                    { 11, 2 },
                    { 11, 3 },
                    { 11, 34 },
                    { 11, 38 },
                    { 12, 33 },
                    { 12, 34 },
                    { 12, 35 },
                    { 12, 36 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DishIngredients_Ingredients_IngredientId",
                table: "DishIngredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DishIngredients_Ingredients_IngredientId",
                table: "DishIngredients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 1, 38 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 2, 38 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 3, 37 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 4, 38 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 5, 39 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 6, 18 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 7, 19 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 7, 20 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 7, 21 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 7, 22 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 8, 23 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 8, 24 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 8, 25 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 8, 26 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 9, 16 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 9, 27 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 9, 28 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 9, 37 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 10, 22 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 10, 30 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 10, 31 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 10, 32 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 11, 34 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 11, 38 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 12, 33 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 12, 34 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 12, 35 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 12, 36 });

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.CreateTable(
                name: "Ingridients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingridients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ingridients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Spaghetti" },
                    { 2, "Ground Beef" },
                    { 3, "Tomato Sauce" },
                    { 4, "Romaine Lettuce" },
                    { 5, "Caesar Dressing" },
                    { 6, "Croutons" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DishIngredients_Ingridients_IngredientId",
                table: "DishIngredients",
                column: "IngredientId",
                principalTable: "Ingridients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
