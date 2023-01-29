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

        public async Task AddBookAsync(Book product)
        {
            _books.Add(product);
            await Task.CompletedTask;
        }

        public async Task<Book> GetBookByIdAsync(int Id)
        {
            return await Task.FromResult(_books.Single(x => x.Id == Id));
        }
    }
}
