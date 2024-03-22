namespace Mission11Rosenlund.Models;

public class EfBookRepository : IBookRepository
{
    private readonly BookstoreContext _context;
    
    public EfBookRepository(BookstoreContext stuff)
    {
        _context = stuff;
    }

    public IQueryable<Book> Books => _context.Books;
}