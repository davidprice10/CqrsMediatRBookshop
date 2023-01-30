using CqrsBookshop.Commands;
using MediatR;

namespace CqrsBookshop.Handlers
{
    public class DeleteBookHandler : IRequestHandler<DeleteBookCommand, Book>
    {
        private readonly DataStore _dataStore;

        public DeleteBookHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<Book> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            await _dataStore.DeleteBookAsync(request.Book);
            return request.Book;
        }
    }
}
