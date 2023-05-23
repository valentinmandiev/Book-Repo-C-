using BookStore.Models.Models;

namespace BookStore.DL.Interfaces
{
    public interface IAuthorRepository1
    {
        Task Add(Author author);
        Task Delete(Guid id);
        Task<IEnumerable<Author>> GetAll();
        Task<Author> GetById(Guid id);
        Task Update(Author author);
    }
}