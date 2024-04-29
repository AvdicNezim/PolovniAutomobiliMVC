namespace PolovniAutomobiliMVC.Models
{
    // Interface koji definira operacije za pristup podacima
    public interface ICarRepository
	{
		IEnumerable<Car> allCars { get; }
		IEnumerable<Car> specialOfferCars { get; }
		Car getCarById(int carId);
	}
}
