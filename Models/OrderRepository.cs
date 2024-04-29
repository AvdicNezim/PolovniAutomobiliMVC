namespace PolovniAutomobiliMVC.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        // Metoda za kreiranje nove narudzbu
        public void CreateOrder(Order order)
        {
            order.orderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.shoppingCartItems;
            order.orderTotal = _shoppingCart.GetShoppingCartTotal();

            order.orderDetails = new List<OrderDetail>();

            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    amount = item.amount,
                    carId = item.car.id,
                    price = item.car.price
                };

                order.orderDetails.Add(orderDetail);
            }

            _appDbContext.orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}