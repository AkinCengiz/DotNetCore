using Project4Odev2.Business;
using Project4Odev2.DataAccess;

namespace Project4Odev2.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager(new AdoBookDal());

            foreach (var book in bookManager.GetBooks())
            {
                Console.WriteLine(book.Name + " " + book.Author);
            }
            Console.WriteLine("**************************************");
            bookManager = new BookManager(new EntityBookDal());
            foreach (var book in bookManager.GetBooks())
            {
                Console.WriteLine(book.Name + " | " + book.Author);
            }
        }
    }
}