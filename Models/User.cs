using Microsoft.AspNetCore.Mvc;

namespace Angelica_MVC_RM550776.Models
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
