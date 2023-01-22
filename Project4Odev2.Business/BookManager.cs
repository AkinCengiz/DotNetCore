using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4Odev2.DataAccess;
using Project4Odev2.Entity;

namespace Project4Odev2.Business
{
    public class BookManager
    {
        private IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public List<Book> GetBooks()
        {
            return _bookDal.GetBooks();
        }
    }
}
