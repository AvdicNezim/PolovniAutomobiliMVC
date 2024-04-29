using Microsoft.AspNetCore.Mvc;
using PolovniAutomobiliMVC.Models;

namespace PolovniAutomobiliMVC.Components
{
    // MVC View komponenta koja generira meni kategorija
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        // Konstruktor za pristup kategorijama
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        // Metoda koja se poziva kada se komponenta renderira
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.allCategories.OrderBy(c => c.name);
            return View(categories);
        }
    }
}