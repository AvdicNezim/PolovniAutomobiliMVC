namespace PolovniAutomobiliMVC.Models
{
    public class ShoppingCartItem
    {
        public int id { get; set; }
        public Car car { get; set; }
        public int amount { get; set; }
        public string shoppingCartId { get; set; }
    }
}