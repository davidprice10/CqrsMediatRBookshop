using CqrsBookshop.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsBookshop.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ISender _sender;

        public BooksController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooksAsync()
        {
            var products = await _sender.Send(new GetBooksRequest());
            return Ok(products);
        }
    }
}
