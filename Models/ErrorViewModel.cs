namespace PolovniAutomobiliMVC.Models
{
    // Klasa koja predstavlja model greske prikazan na stranici kada dodje do greske
    public class ErrorViewModel
	{
        // ID zahtjeva koji je generiran kada dodje do greske
        public string? RequestId { get; set; }

        // Metoda koja provjerava postoji li ID zahtjeva
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
	}
}
