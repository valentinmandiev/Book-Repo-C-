

using BookStore.BL.Interfaces;
using BookStore.Models.Base;

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

    }
    public interface ILifeTimeService
    {

    }
}
