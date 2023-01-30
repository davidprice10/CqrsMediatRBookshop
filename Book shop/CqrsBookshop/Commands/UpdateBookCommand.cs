using MediatR;

namespace CqrsBookshop.Commands
{
    public record UpdateBookCommand(Book Book) : IRequest<Book>;
}
