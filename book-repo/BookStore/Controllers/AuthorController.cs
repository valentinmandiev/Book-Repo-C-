using BookStore.BL.Interfaces;
using BookStore.Models.Models;
using BookStore.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly IAuthorService _authorService;

        public AuthorController(
            ILogger<AuthorController> logger,
            IAuthorService authorService)
        {
            _logger = logger;
            _authorService = authorService;
        }

        [HttpGet("GetAllAuthors")]
        public IEnumerable<Author> GetAll()
        {
            try
            {
                _logger.LogError("GetAll returns error");
                return _authorService.GetAll();

            }
            catch (Exception e)
            {
                _logger.LogError("GetAll returns error");
            }
            return _authorService.GetAll();

        }

        [HttpGet("GetById")]
        public Author GetById(int id)
        {
            return _authorService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] AddAuthorRequest authorRequest)
        {
            _authorService.Add(authorRequest);
        }

        [HttpPost("Update")]
        public void Update([FromBody] UpdateAuthorRequest author)
        {
            _authorService.Update(author);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _authorService.Delete(id);
        }
    }
}