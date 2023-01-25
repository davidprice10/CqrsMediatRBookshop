namespace CqrsBookshop
{
    public class DataStore
    {
        private static List<Book> _books;

        public DataStore()
        {
            _books = new List<Book>()
            {
                new() { Id = 1, Name = "TestProduct1" },
                new() { Id = 2, Name = "TestProduct2" },
                new() { Id = 3, Name = "TestProduct3" }
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
    }
}
