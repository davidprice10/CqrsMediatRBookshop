using CqrsBookshop.Notifications;
using MediatR;

namespace CqrsBookshop.Handlers
{
    public class EmailHandler : INotificationHandler<BookAddedNotification>
    {

        private readonly DataStore _dataStore;

        public EmailHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }
        public async Task Handle(BookAddedNotification notification, CancellationToken cancellationToken)
        {
            await _dataStore.EventOccurred(notification.book, "Email sent");
            await Task.CompletedTask;
        }
    }
}
