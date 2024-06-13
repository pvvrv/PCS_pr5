using Microsoft.AspNetCore.Mvc;
using System.Linq;
using _5pks.models;
using System.Collections.Generic;
namespace _5pks.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Performance()
        {
            var performances = _context.Performances.ToList();
            return View(performances);
        }

        public IActionResult Achievements(string filterType, DateTime? filterDate)
        {
            var achievements = _context.Achievements.AsQueryable();

            if (!string.IsNullOrEmpty(filterType))
            {
                achievements = achievements.Where(a => a.Type == filterType);
            }

            if (filterDate.HasValue)
            {
                achievements = achievements.Where(a => a.Date.Date == filterDate.Value.Date);
            }

            return View(achievements.ToList());
        }

        public IActionResult Teachers()
        {
            var teachers = _context.Teachers.ToList();
            return View(teachers);
        }
    }
}
