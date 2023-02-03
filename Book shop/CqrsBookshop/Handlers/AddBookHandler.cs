using CqrsBookshop.Commands;
using CqrsBookshop.Notifications;
using MediatR;

namespace CqrsBookshop.Handlers
{
    public class AddBookHandler : IRequestHandler<AddBookCommand, Book>
    {
        private readonly DataStore _dataStore;
        private readonly IPublisher _publisher;


        public AddBookHandler(DataStore dataStore, IPublisher publisher)
        {
            _dataStore = dataStore;
            _publisher = publisher;
        }

        public async Task<Book> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            await _dataStore.AddBookAsync(request.Book);
            await _publisher.Publish(new BookAddedNotification(request.Book), cancellationToken);
            return request.Book;
        }
    }
}
