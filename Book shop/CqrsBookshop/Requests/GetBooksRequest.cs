using MediatR;

namespace CqrsBookshop.Requests
{
    public record GetBooksRequest: IRequest<IEnumerable<Book>>
    {

    }
}