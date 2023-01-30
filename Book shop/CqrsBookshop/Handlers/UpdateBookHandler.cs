using CqrsBookshop.Commands;
using MediatR;

namespace CqrsBookshop.Handlers
{
    public class UpdateBookHandler : IRequestHandler<UpdateBookCommand, Book>
    {
        private readonly DataStore _dataStore;

        public UpdateBookHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<Book> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            await _dataStore.UpdateBookAsync(request.Book);
            return request.Book;
        }
    }
}
