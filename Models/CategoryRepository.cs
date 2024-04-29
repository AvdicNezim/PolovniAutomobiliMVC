namespace PolovniAutomobiliMVC.Models
{
    // Klasa koja sluzi za pristup kategorijama
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // Metoda za dohvacanje svih kategorija iz baze podataka
        public IEnumerable<Category> allCategories => _appDbContext.categories;
    }
}
