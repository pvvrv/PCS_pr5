using _5pks.models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace _5pks.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var student = _context.Students.FirstOrDefault(s => s.Email == model.Email && s.Password == model.Password);
                if (student != null)
                {
                    // Успешная авторизация, перенаправление в личный кабинет
                    return RedirectToAction("Index", "Student");
                }

                // Ошибка авторизации
                ModelState.AddModelError("", "Неверный email или пароль");
            }
            return View(model);
        }
    }
}
