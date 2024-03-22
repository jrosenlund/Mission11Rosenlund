namespace Mission11Rosenlund.Models.ViewModels;

public class ProjectsList
{
    public IQueryable<Book> Books { get; set; }
    public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
}