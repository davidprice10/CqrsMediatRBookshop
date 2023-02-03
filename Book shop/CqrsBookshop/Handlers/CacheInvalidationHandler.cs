using CqrsBookshop.Notifications;
using MediatR;

namespace CqrsBookshop.Handlers
{
    public class CacheInvalidationHandler: INotificationHandler<BookAddedNotification>
    {
        private readonly DataStore _dataStore;

        public CacheInvalidationHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task Handle(BookAddedNotification notification, CancellationToken cancellationToken)
        {
            await _dataStore.EventOccurred(notification.book, "Cache Invalidated");
            await Task.CompletedTask;
        }
    }
}
