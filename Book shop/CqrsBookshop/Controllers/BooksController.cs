using CqrsBookshop.Commands;
using CqrsBookshop.Notifications;
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
            var books = await _mediator.Send(new GetBooksRequest());
            return Ok(books);
        }

        [HttpGet("{id:int}", Name = "GetBookById")]
        public async Task<IActionResult> GetBookByIdAsync(int id)
        {
            var book = await _mediator.Send(new GetBookByIdRequest(id));
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddBookAsync([FromBody] Book book)
        {
            var addedBook = await _mediator.Send(new AddBookCommand(book));
            return CreatedAtRoute("GetBookById", new { id = addedBook.Id }, addedBook);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteBookAsync(int id)
        {
            await _mediator.Send(new DeleteBookCommand(id));
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBookAsync([FromBody] Book book)
        {
            await _mediator.Send(new UpdateBookCommand(book));
            return Ok(book);
        }

    }
}
