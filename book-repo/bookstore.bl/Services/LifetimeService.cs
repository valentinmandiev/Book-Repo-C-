

using BookStore.BL.Interfaces;
using BookStore.Models.Base;
using BookStore.Models.Requests;

namespace BookStore.BL.Services
{
    public class LifetimeService : IAuthorService
    {
        private string _id;
        public LifetimeService()
        {
            _id= Guid.NewGuid().ToString();
        }

        public void Add(Author author)
        {
            throw new NotImplementedException();
        }

        public void Add(AddAuthorRequest author)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAll()
        {
            throw new NotImplementedException();
        }

        public Author GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string GetId()
        {
            return _id; 
        }

        public void Update(UpdateAuthorRequest author)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Models.Models.Author> IAuthorService.GetAll()
        {
            throw new NotImplementedException();
        }

        Models.Models.Author IAuthorService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
    public interface ILifeTimeService
    {

    }
}
