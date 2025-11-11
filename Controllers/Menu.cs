using Microsoft.AspNetCore.Mvc;
using Menu.Models;
using Menu.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Menu.Controllers
{
    public class Menu : Controller
    { 
        private readonly MenuContext _context; 
        public Menu(MenuContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {   
 try
    {
       var dishes = _context.Dishes.AsQueryable();
                
      if (!String.IsNullOrEmpty(searchString))
      {
       dishes = dishes.Where(s => s.Name.ToLower().Contains(searchString.ToLower()));
        }
       
         return View(await dishes.ToListAsync());
   }
    catch (Exception ex)
   {
        // Log the error
        return View(new List<Dish>());
}
        }

        public async Task<IActionResult> Details(int? id)
    {
            if (id == null)
            {
        return BadRequest();
      }

        try
  {
     var dish = await _context.Dishes
           .AsNoTracking()
          .Include(d => d.DishIngredients)
    .ThenInclude(di => di.Ingredient)
            .FirstOrDefaultAsync(x => x.Id == id);

           if (dish == null)
            {
            return NotFound();
      }

  return View(dish);
     }
            catch (Exception ex)
      {
       // Log the error
     return NotFound();
            }
        }
    }
}
