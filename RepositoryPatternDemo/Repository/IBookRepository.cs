using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBookById(int id);
        int AddBook(Book book);
        int UpdateBook(Book book);
        int DeleteBook(int id);

    }
}
