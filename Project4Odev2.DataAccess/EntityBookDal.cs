using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Project4Odev2.Entity;

namespace Project4Odev2.DataAccess
{
    public class EntityBookDal:IBookDal
    {
        private List<Book> _books;

        public EntityBookDal()
        {
            _books = new List<Book>()
            {
                new Book() { Id = 1, Name = "Tutunamayanlar - Entity", Author = "Oğuz ATAY", Type = "Roman" },
                new Book() { Id = 2, Name = "Sefiller - Entity", Author = "Victor HUGO", Type = "Roman" },
                new Book() { Id = 3, Name = "Ölümcül Virüs - Entity", Author = "Tess GERRITSEN", Type = "Roman" },
                new Book() { Id = 4, Name = "Cerrah - Entity", Author = "Tess GERRITSEN", Type = "Roman" },
                new Book() { Id = 5, Name = "Tehlikeli Oyunlar - Entity", Author = "Oğuz ATAY", Type = "Roman" }
            };
        }
        public List<Book> GetBooks()
        {
            return _books;
        }

        public void Add(Book book)
        {
            _books.Add(book);
            Console.WriteLine("Entity ile eklendi...");
        }
    }
}
