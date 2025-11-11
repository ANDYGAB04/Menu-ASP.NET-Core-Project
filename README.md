# ??? Restaurant Menu Application

A modern, responsive ASP.NET Core web application for browsing and searching a restaurant's menu items. Built with C#, Entity Framework Core, and Bootstrap 5.

![.NET Version](https://img.shields.io/badge/.NET-9.0-512BD4)
![License](https://img.shields.io/badge/License-MIT-green)
![Build Status](https://img.shields.io/badge/Build-Passing-brightgreen)

## ?? Features

- **Responsive Design**: Mobile-friendly interface that works on all devices
- **Search Functionality**: Search dishes by name with case-insensitive matching
- **Rich Menu**: 12+ dishes with detailed information including ingredients
- **Professional UI**: Modern Bootstrap 5 design with smooth animations
- **Ingredient Tracking**: Complete ingredient lists for each dish with pricing
- **Fast Performance**: Optimized database queries with Entity Framework Core

## ?? Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Server Express)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. **Clone the repository**
   ```bash
git clone https://github.com/ANDYGAB04/Menu-ASP.NET-Core-Project-.git
   cd Menu
   ```

2. **Configure the database connection**
   - Open `appsettings.json`
   - Update the `DefaultConnectionString` to point to your SQL Server instance:
   ```json
 "ConnectionStrings": {
     "DefaultConnectionString": "Server=YOUR_SERVER;Database=MenuDB;Trusted_Connection=true;TrustServerCertificate=true;"
   }
   ```

3. **Restore dependencies**
   ```bash
   dotnet restore
   ```

4. **Apply database migrations**
   ```bash
   dotnet ef database update
   ```

5. **Run the application**
   ```bash
   dotnet run
   ```

6. **Open in browser**
   - Navigate to `https://localhost:7000` (or the port shown in the console)

## ?? Project Structure

```
Menu/
??? Controllers/
?   ??? HomeController.cs          # Home page controller
?   ??? MenuController.cs          # Menu browsing and search logic
??? Models/
?   ??? Dish.cs         # Dish model
???? Ingredients.cs     # Ingredients model
?   ??? DishIngredient.cs          # Junction table model
??? Views/
?   ??? Home/
?   ? ??? Index.cshtml      # Home page
?   ??? Menu/
?   ?   ??? Index.cshtml       # Menu listing page
?   ?   ??? Details.cshtml         # Dish details page
?   ??? Shared/
?     ??? _Layout.cshtml  # Master layout
??? Data/
?   ??? MenuContext.cs  # Entity Framework DbContext
??? Program.cs     # Application startup configuration
??? appsettings.json           # Configuration file
```

## ?? Features in Detail

### Menu Listing
- Grid layout displaying all dishes
- Each card shows dish name, image, and price
- Hover effects for better interactivity
- Quick access to detailed view

### Dish Details
- Full dish information including all ingredients
- Professional card-based layout
- Easy navigation back to menu

### Search Functionality
- Real-time search for dishes
- Case-insensitive matching
- Located in the navbar for easy access

## ?? Database Schema

### Dishes Table
- `Id` (Primary Key)
- `Name`
- `Price`
- `ImageUrl`

### Ingredients Table
- `Id` (Primary Key)
- `Name`

### DishIngredients Table (Junction)
- `DishId` (Foreign Key)
- `IngredientId` (Foreign Key)

## ?? Technology Stack

- **Backend**: ASP.NET Core 9.0
- **Language**: C# 13
- **Database**: SQL Server with Entity Framework Core
- **Frontend**: HTML5, CSS3, Bootstrap 5
- **Icons**: Font Awesome 7.0.1
- **Data Access**: Entity Framework Core with LINQ

## ?? Current Menu Items

1. Spaghetti Bolognese - $12.99
2. Caesar Salad - $9.99
3. Margherita Pizza - $14.99
4. Chicken Alfredo - $15.99
5. Pad Thai - $11.99
6. Sushi Platter - $18.99
7. Greek Salad - $10.99
8. Beef Tacos - $9.99
9. Grilled Salmon - $19.99
10. Vegetable Curry - $12.99
11. Lasagna - $13.99
12. Chocolate Cake - $7.99

## ?? Deployment

### Deploy to Azure App Service

1. Create an Azure App Service resource
2. Configure the connection string in Azure
3. Publish using Visual Studio or Azure CLI:
   ```bash
   dotnet publish -c Release
   ```

## ?? Known Issues

- Image URLs are external and may not load if internet is unavailable
- Search is performed on retrieved data (consider database-level search for large datasets)

## ?? Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## ?? License

This project is licensed under the MIT License - see the LICENSE file for details.

## ????? Author

**Andy Gabriel**
- GitHub: [@ANDYGAB04](https://github.com/ANDYGAB04)
- Project: [Menu-ASP.NET-Core-Project](https://github.com/ANDYGAB04/Menu-ASP.NET-Core-Project-)

## ?? Contact & Support

For questions or issues, please open an issue on the [GitHub repository](https://github.com/ANDYGAB04/Menu-ASP.NET-Core-Project-/issues).

## ?? Acknowledgments

- Bootstrap for the responsive framework
- Font Awesome for beautiful icons
- Microsoft for ASP.NET Core framework
- The open-source community

---

? If you find this project useful, please consider giving it a star!