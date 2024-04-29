namespace PolovniAutomobiliMVC.Models
{
    // Interface koji definira operacije za pristup podacima
    public interface ICategoryRepository
    {
        IEnumerable<Category> allCategories { get; }
    }
}
