using MagicMushroom.Data;
using Microsoft.AspNetCore.Mvc;
using MagicMushroom.Models;
using Microsoft.EntityFrameworkCore;


namespace MagicMushroom.Controllers
{
    public class CharacterController : Controller
    {
        private readonly CharacterContext _context;

        public CharacterController(CharacterContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name, Gender, Mushroom")] Character character)
        {
            if (ModelState.IsValid)
            {
                _context.Characters.Add(character);
                await _context.SaveChangesAsync();
                return View();
            }
            return View("Index");
        }
    }
}
