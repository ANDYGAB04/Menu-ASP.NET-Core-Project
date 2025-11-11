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
            var dishes = from d in _context.Dishes
                       select d;
            if(!String.IsNullOrEmpty(searchString))
            {
                dishes = dishes.Where(s => s.Name.Contains(searchString));
                return View(await dishes.ToListAsync());
            }
                return View(await dishes.ToListAsync());
        }

        public async Task<IActionResult> Details (int? id)
        {
            var dish = await _context.Dishes
                .Include(di=>di.DishIngredients)
                .ThenInclude(i=>i.Ingredient)
                .FirstOrDefaultAsync(x=>x.Id==id );
            if(dish==null)
            {
                return NotFound();
            }   
            return View(dish);
        }
    }
}
