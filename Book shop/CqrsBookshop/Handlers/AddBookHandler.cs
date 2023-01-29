using CqrsBookshop.Commands;
using MediatR;

namespace CqrsBookshop.Handlers
{
    public class AddBookHandler : IRequestHandler<AddBookCommand, Book>
    {
        private readonly DataStore _dataStore;

        public AddBookHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<Book> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            await _dataStore.AddBookAsync(request.Book);
            return request.Book;
        }
    }
}
