using Microsoft.EntityFrameworkCore;

namespace PolovniAutomobiliMVC.Models
{
    // Klasa koja sluzi za pristup podacima o autima
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // Metoda za dohvacanje svih automobila i kategorija iz baze podataka
        public IEnumerable<Car> allCars => _appDbContext.cars.Include(c => c.category);

        // Metoda za dohvacanje automobila i kategorija koji imaju specijalnu ponudu
        public IEnumerable<Car> specialOfferCars => _appDbContext.cars.Include(c => c.category).Where(s => s.isSpecialOffer);

        // Metoda za dohvacanje odredjenog automobila
        public Car getCarById(int carId) => _appDbContext.cars.FirstOrDefault(c => c.id == carId);
    }
}