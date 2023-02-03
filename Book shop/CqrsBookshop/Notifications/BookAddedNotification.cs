using MediatR;

namespace CqrsBookshop.Notifications
{
    public record BookAddedNotification(Book book) : INotification;
}
