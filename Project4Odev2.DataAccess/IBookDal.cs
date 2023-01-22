using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4Odev2.Entity;

namespace Project4Odev2.DataAccess
{
    public interface IBookDal
    {
        List<Book> GetBooks();
        void Add(Book book);
    }
}
