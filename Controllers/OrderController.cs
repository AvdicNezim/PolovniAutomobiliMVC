using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PolovniAutomobiliMVC.Models;
using PolovniAutomobiliMVC.ViewModels;

namespace PolovniAutomobiliMVC.Controllers
{
    // Kontroler za upravljanje akcijama vezanim za narucivanje
    [Authorize] // Zahtijeva autentifikaciju korisnika prije pristupa akcijama ovog kontrolera
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        // Konstruktor za pristup autima i korpi
        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        // Akcija za prikaz stranice za naplatu narudzbe
        public IActionResult Checkout()
        {
            return View();
        }

        // Akcija za obradu narudzbe
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.shoppingCartItems = items;

            if (_shoppingCart.shoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty :(");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        // Akcija za prikaz stranice s potvrdom narudzbe
        public IActionResult CheckoutComplete()
        {
            CheckoutCompleteViewModel message = new CheckoutCompleteViewModel()
            {
                message = "Your order is on your way!"
            };
            return View(message);
        }
    }
}