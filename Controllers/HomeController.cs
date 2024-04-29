using Microsoft.AspNetCore.Mvc;
using PolovniAutomobiliMVC.Models;
using PolovniAutomobiliMVC.ViewModels;
using System.Diagnostics;

namespace PolovniAutomobiliMVC.Controllers
{
    // Kontroler za upravljanje akcijama vezanim sa osnovnim stranicama kao sto su pocetna, privatnost i greska
    public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ICarRepository _carRepository;

        // Konstruktor za pristup logeru i autima
        public HomeController(ILogger<HomeController> logger, ICarRepository carRepository)
		{
			_logger = logger;
			_carRepository = carRepository;
		}

        // Akcija za prikaz pocetne stranice
        public IActionResult Index()
		{
			HomeViewModel model = new HomeViewModel();
			model.specialOffers = _carRepository.specialOfferCars;
			return View(model);
		}

        // Akcija za prikaz stranice o privatnosti
        public IActionResult Privacy()
		{
			return View();
		}

        // Akcija za prikaz stranice sa greskom
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}