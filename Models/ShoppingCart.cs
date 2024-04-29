using Microsoft.EntityFrameworkCore;

namespace PolovniAutomobiliMVC.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;

        public string id { get; set; }
        public List<ShoppingCartItem> shoppingCartItems { get; set; }

        private ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // Metoda koja dohvaca korpu ili stvara novu korpu ako u tom trenutku ne postoji aktivna korpa
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();

            session.SetString("cartId", cartId);

            return new ShoppingCart(context) { id = cartId };
        }

        // Metoda koja dodaje automobil u korpu za kupovinu
        public void AddToCart(Car car, int amount)
        {
            var shoppingCartItem =
                    _appDbContext.shoppingCartItems.SingleOrDefault(
                        s => s.car.id == car.id && s.shoppingCartId == id);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    shoppingCartId = id,
                    car = car,
                    amount = 1
                };

                _appDbContext.shoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.amount++;
            }
            _appDbContext.SaveChanges();
        }

        // Metoda koja uklanja automobil iz korpe za kupovinu
        public int RemoveFromCart(Car car)
        {
            var shoppingCartItem =
                    _appDbContext.shoppingCartItems.SingleOrDefault(
                        s => s.car.id == car.id && s.shoppingCartId == id);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.amount > 1)
                {
                    shoppingCartItem.amount--;
                    localAmount = shoppingCartItem.amount;
                }
                else
                {
                    _appDbContext.shoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        // Metoda koja dohvaca informacije korpe
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return shoppingCartItems ??
                   (shoppingCartItems =
                       _appDbContext.shoppingCartItems.Where(c => c.shoppingCartId == id)
                           .Include(s => s.car)
                           .ToList());
        }

        // Metoda koja brise sve artikle iz korpe
        public void ClearCart()
        {
            var cartItems = _appDbContext
                .shoppingCartItems
                .Where(cart => cart.shoppingCartId == id);

            _appDbContext.shoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        // Metoda koja izracunava ukupnu cijenu artikala koji se nalaze u korpi
        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.shoppingCartItems.Where(c => c.shoppingCartId == id)
                .Select(c => c.car.price * c.amount).Sum();
            return total;
        }
    }
}