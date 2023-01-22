using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4Odev2.Entity;

namespace Project4Odev2.DataAccess
{
    public class AdoBookDal:IBookDal
    {
        private List<Book> _books;

        public AdoBookDal()
        {
            _books = new List<Book>()
            {
                new Book() { Id = 1, Name = "Tutunamayanlar - ADO", Author = "Oğuz ATAY", Type = "Roman" },
                new Book() { Id = 2, Name = "Sefiller - ADO", Author = "Victor HUGO", Type = "Roman" },
                new Book() { Id = 3, Name = "Ölümcül Virüs - ADO", Author = "Tess GERRITSEN", Type = "Roman" },
                new Book() { Id = 4, Name = "Cerrah - ADO", Author = "Tess GERRITSEN", Type = "Roman" },
                new Book() { Id = 5, Name = "Tehlikeli Oyunlar - ADO", Author = "Oğuz ATAY", Type = "Roman" }
            };
        }

        public List<Book> GetBooks()
        {
            return _books;
        }

        public void Add(Book book)
        {
            _books.Add(book);
            Console.WriteLine("ADO ile eklendi...");
        }
    }
}
