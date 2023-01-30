using MediatR;

namespace CqrsBookshop.Commands
{
    public record DeleteBookCommand (int Id) : IRequest<Book>;
}
