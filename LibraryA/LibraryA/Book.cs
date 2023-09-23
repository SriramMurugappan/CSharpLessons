using System.Net;

namespace LibraryA
{
    public class Book
    {
        public String Title = String.Empty;
        public String Author = String.Empty;
        public String Genre = String.Empty;
        public DateTime DateofPublish;
        public int bookprice;
        public int TotalPages = 300;
        public void OpenBook()
        {
            Console.WriteLine("Book is Open");
        }
        public void BookMarkPage(int pageNo)
        {
            Console.WriteLine($" Page No: {pageNo} BookMarkPage");
        }



        public int GetCurrentPage()
        {
            Random rnd = new Random();
            return rnd.Next(TotalPages);
        }
    }
}