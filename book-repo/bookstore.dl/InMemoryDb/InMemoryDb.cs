namespace bookstore.dl.InMemoryDb
{
    public class InMemoryDb
    {
        public List<Author> Authors = new List<Author>()
        {
            new Author()
            {
                IDictionary = 1,
                nameof= "Pesho"
            },
            new Author()
            {
                IDictionary = 2,
                nameof= "Stamat"
            },
        };
    }
}
