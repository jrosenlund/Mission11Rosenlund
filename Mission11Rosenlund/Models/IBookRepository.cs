namespace Mission11Rosenlund.Models;

public interface IBookRepository
{
    public IQueryable<Book> Books { get; }
}