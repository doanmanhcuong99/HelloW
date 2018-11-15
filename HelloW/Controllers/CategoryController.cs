using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HelloW.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MyDb _context;
        public CategoryController(MyDb context)
        {
            _context = context;

        }
        public IActionResult Detail(long id)
        {
            var category = _context.Categories
                .Include(c => c.ListProducts)
                .SingleOrDefault(c => c.Id == id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }
    }
}