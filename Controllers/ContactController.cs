using Microsoft.AspNetCore.Mvc;

namespace PolovniAutomobiliMVC.Controllers
{
    // Kontroler za upravljanje akcije vezane za kontakt informacije
    public class ContactController : Controller
    {
        // Akcija za prikaz stranice sa kontakt informacijama
        public IActionResult Index()
        {
            return View();
        }
    }
}