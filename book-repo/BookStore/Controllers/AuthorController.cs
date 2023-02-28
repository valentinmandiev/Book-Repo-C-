using BookStore.BL.Interfaces;
using BookStore.Models.Base;
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

        [HttpGet(Name = "GetAllAuthors")]
        public IEnumerable<Author> GetAll()
        {
           return _authorService.GetAll();
        }
    }
}