using Microsoft.VisualBasic.FileIO;

namespace PolovniAutomobiliMVC.Models
{
	public class Car
	{
		public int id { get; set; }
		public string name { get; set; }
		public string descriptionShort { get; set; }
		public string description { get; set; }
		public decimal price { get; set; }
		public string imageUrl { get; set; }
		public string imageUrlThumbnail { get; set; }
		public bool isSpecialOffer { get; set; }
		public int fuelTypeId { get; set; }
		public int categoryId { get; set; }
		public Category category { get; set; }
		public FuelType fuelType { get; set; }
	}
}
