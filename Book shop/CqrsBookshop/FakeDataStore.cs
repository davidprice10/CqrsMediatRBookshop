namespace CqrsBookshop
{
    public class FakeDataStore
    {
        private static List<Product> _products;

        public FakeDataStore()
        {
            _products = new List<Product>()
            {
                new() { Id = 1, Name = "TestProduct1" },
                new() { Id = 2, Name = "TestProduct2" },
                new() { Id = 3, Name = "TestProduct3" }
            };
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await Task.FromResult(_products);
        }

        public async Task AddProductAsync(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }
    }
}
