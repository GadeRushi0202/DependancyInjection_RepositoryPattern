using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Repository;

namespace RepositoryPatternDemo.Services
{
    public class BookService : IBookService
    {
        // Need to inject Repository as its dependency.
        private readonly IBookRepository repo;
        public BookService(IBookRepository repo)
        {
            this.repo = repo;
        }
        int IBookService.AddBook(Book book)
        {
            return repo.AddBook(book);
        }

        int IBookService.DeleteBook(int id)
        {
            return repo.DeleteBook(id);
        }

        Book IBookService.GetBookById(int id)
        {
            return repo.GetBookById(id);
        }

        IEnumerable<Book> IBookService.GetBooks()
        {
            return repo.GetBooks();
        }

        int IBookService.UpdateBook(Book book)
        {
            return repo.UpdateBook(book);
        }
    }
}