using System.Security.Cryptography.Xml;

namespace CqrsBookshop
{
    public class DataStore
    {
        private static List<Book> _books;

        public DataStore()
        {
            _books = new List<Book>
            {
                new() { Id = 1, Name = "TestBook1" },
                new() { Id = 2, Name = "TestBook2" },
                new() { Id = 3, Name = "TestBook3" }
            };
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await Task.FromResult(_books);
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await Task.FromResult(_books.Single(x => x.Id == id));
        }

        public async Task AddBookAsync(Book book)
        {
            _books.Add(book);
            await Task.CompletedTask;
        }

        public async Task DeleteBookAsync(Book book)
        {
            _books.Remove(book);
            await Task.CompletedTask;
        }

        public async Task UpdateBookAsync(Book book)
        {
            _books.Where(x => x.Id == book.Id).ToList().ForEach(i => i.Name = book.Name);
            await Task.CompletedTask;
        }
    }
}
