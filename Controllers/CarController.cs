using Microsoft.AspNetCore.Mvc;
using PolovniAutomobiliMVC.Models;
using PolovniAutomobiliMVC.ViewModels;

namespace PolovniAutomobiliMVC.Controllers
{
    // Kontroler za upravljanje akcijama vezanim za automobile
    public class CarController : Controller
	{
		private readonly ICarRepository _carRepository;
		private readonly ICategoryRepository _categoryRepository;

        // Konstruktor za pristup autima
        public CarController(ICarRepository carRepository, ICategoryRepository categoryRepository)
		{
			_carRepository = carRepository;
			_categoryRepository = categoryRepository;
		}

        // Akcija za prikaz liste automobila
        public ViewResult List(int? categoryId)
		{
			CarListViewModel carListViewModel = new CarListViewModel()
			{
				cars = _carRepository.allCars,
				currentCategory = "All cars"
			};

			if (categoryId.HasValue)
			{
				carListViewModel.cars = _carRepository.allCars
														.Where(c => categoryId.HasValue && c.categoryId == categoryId);
				carListViewModel.currentCategory = _categoryRepository.allCategories
																		.Where(c => c.id == categoryId.Value)
																		.Select(c => c.name)
																		.FirstOrDefault();
			}

			return View(carListViewModel);
		}

        // Akcija za prikaz detalja o odredjenom automobilu
        public IActionResult Details(int id)
		{
			var car = _carRepository.getCarById(id);
			if (car == null)
			{
				return NotFound();
			}
			return View(car);
		}
	}
}