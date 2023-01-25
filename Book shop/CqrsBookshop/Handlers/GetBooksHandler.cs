using CqrsBookshop.Requests;
using MediatR;

namespace CqrsBookshop.Handlers
{
    public class GetBooksHandler: IRequestHandler<GetBooksRequest, IEnumerable<Book>>
    {
        private readonly DataStore _dataStore;
        public GetBooksHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<IEnumerable<Book>> Handle(GetBooksRequest request, CancellationToken cancellationToken)
        {
            return await _dataStore.GetAllBooksAsync();
        }
    }
}
