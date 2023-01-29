using MediatR;

namespace CqrsBookshop.Requests
{
    public record GetBookByIdRequest(int Id) : IRequest<Book>;
}
