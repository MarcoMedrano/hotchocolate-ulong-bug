namespace ULONG;

public class Query
{
    public Book GetBook()
        => new Book("C# in depth.", new Author("Jon Skeet"), 5000);
    
    // [UseOffsetPaging(IncludeTotalCount = true)]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public virtual IQueryable<Poco> GetPocos()
    {
        var list = new List<Poco>{new Poco(), new Poco()};

        return list.AsQueryable();
    }
}

public record Book(string Title, Author Author, ulong pages);

public record Author(string Name);
