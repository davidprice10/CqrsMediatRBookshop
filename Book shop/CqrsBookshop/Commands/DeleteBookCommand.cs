using MediatR;

namespace CqrsBookshop.Commands
{
    public record DeleteBookCommand (Book Book) : IRequest<Book>;
}
