using PolovniAutomobiliMVC.Models;

namespace PolovniAutomobiliMVC.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart shoppingCart { get; set; }
        public decimal totalPrice { get; set; }
    }
}