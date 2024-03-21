using Microsoft.EntityFrameworkCore;

namespace AmazonWebsite.Models;

public interface IBookRepository
{
    IEnumerable<Book> Books { get; }
}