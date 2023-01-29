using CqrsBookshop.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsBookshop.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooksAsync()
        {
            var products = await _mediator.Send(new GetBooksRequest());
            return Ok(products);
        }
    }
}
