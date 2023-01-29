using CqrsBookshop.Requests;
using MediatR;

namespace CqrsBookshop.Handlers
{
    public class GetBookByIdHandler : IRequestHandler<GetBookByIdRequest, Book>
    {
        private readonly DataStore _dataStore;

        public GetBookByIdHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<Book> Handle(GetBookByIdRequest request, CancellationToken cancellationToken)
        {
            return await _dataStore.GetBookByIdAsync(request.Id);
        }
    }
}
