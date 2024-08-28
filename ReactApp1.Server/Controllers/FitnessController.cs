using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using WebApi_Respository_Pattren.Models;
using WebApi_Respository_Pattren.Repository;

namespace WebApi_Respository_Pattren.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FitnessController : Controller
    {
        private readonly IFitness _booksService;

        public FitnessController(Fitness_Repository booksService) =>
            _booksService = booksService;

        [HttpGet]
        public async Task<List<MFitness>> Get() =>
            await _booksService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<MFitness>> Get(string id)
        {
            var book = await _booksService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost]
        public async Task<IActionResult> Post(MFitness newBook)
        {
            await _booksService.CreateAsync(newBook);

            return CreatedAtAction(nameof(Get), new { id = newBook.Id }, newBook);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, MFitness updatedBook)
        {
            var book = await _booksService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            updatedBook.Id = book.Id;

            await _booksService.UpdateAsync(id, updatedBook);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var book = await _booksService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            await _booksService.RemoveAsync(id);

            return NoContent();
        }
    }
}
