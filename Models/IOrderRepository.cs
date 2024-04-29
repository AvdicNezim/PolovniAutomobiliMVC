namespace PolovniAutomobiliMVC.Models
{
    // Interface koji definira operacije za pristup podacima
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}