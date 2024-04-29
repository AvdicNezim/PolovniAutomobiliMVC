using Microsoft.AspNetCore.Mvc;
using PolovniAutomobiliMVC.Models;
using PolovniAutomobiliMVC.ViewModels;

namespace PolovniAutomobiliMVC.Controllers
{
    // Kontroler za upravljanje akcijama vezanim za korpu
    public class ShoppingCartController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly ShoppingCart _shoppingCart;

        // Konstruktor za pristup autima i korpi
        public ShoppingCartController(ICarRepository carRepository, ShoppingCart shoppingCart)
        {
            _carRepository = carRepository;
            _shoppingCart = shoppingCart;
        }

        // Akcija za prikaz korpe
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.shoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                shoppingCart = _shoppingCart,
                totalPrice = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        // Akcija za dodavanje automobila u korpu
        public RedirectToActionResult AddToShoppingCart(int carId)
        {
            var selectedCar = _carRepository.allCars.FirstOrDefault(p => p.id == carId);

            if (selectedCar != null)
            {
                _shoppingCart.AddToCart(selectedCar, 1);
            }
            return RedirectToAction("Index");
        }

        // Akcija za uklanjanje automobila iz korpe
        public RedirectToActionResult RemoveFromShoppingCart(int carId)
        {
            var selectedCar = _carRepository.allCars.FirstOrDefault(p => p.id == carId);

            if (selectedCar != null)
            {
                _shoppingCart.RemoveFromCart(selectedCar);
            }
            return RedirectToAction("Index");
        }
    }
}