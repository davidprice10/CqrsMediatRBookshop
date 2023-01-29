using MediatR;

namespace CqrsBookshop.Commands
{
    public record AddBookCommand(Book Book) : IRequest<Book>;

}
