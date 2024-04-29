﻿namespace PolovniAutomobiliMVC.Models
{
	public class Category
	{
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public List<Car> cars { get; set; }
	}
}
