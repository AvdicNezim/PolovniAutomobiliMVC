using PolovniAutomobiliMVC.Models;

namespace PolovniAutomobiliMVC.ViewModels
{
	public class CarListViewModel
	{
		public IEnumerable<Car> cars { get; set; }
		public string currentCategory { get; set; }
	}
}
