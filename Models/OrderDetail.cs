namespace PolovniAutomobiliMVC.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public int carId { get; set; }
        public int amount { get; set; }
        public decimal price { get; set; }
        public Car car { get; set; }
        public Order order { get; set; }
    }
}