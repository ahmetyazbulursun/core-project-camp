using Microsoft.AspNetCore.Mvc;

namespace first_app.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
