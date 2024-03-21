using AmazonWebsite.Context;
using Microsoft.EntityFrameworkCore;

namespace AmazonWebsite.Models;

public class EfBookRepository : IBookRepository
{
    private BookContext _context;

    public EfBookRepository(BookContext temp)
    {
        _context = temp;
    }
    
    public IEnumerable<Book> Books => _context.Books;
}