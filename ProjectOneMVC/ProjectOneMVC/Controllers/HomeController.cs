using Microsoft.AspNetCore.Mvc;
using ProjectOneMVC.Models;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace ProjectOneMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SayHello(string name)
        {
            if (string.IsNullOrEmpty(name))
                ViewData["v1"] = "Name is Empty";
            else
                ViewData["v1"] = name;
            return View();
        }
        public IActionResult Add(int x, int y)
        {
            int result = x + y;
            ViewData["addResult"] = result;
            return View();
        }
        

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AddnewBook()
        {
            Book book = new Book();
            return View(book);
        }
        public IActionResult SavenewBook(Book pBook)
        {
            string fname = @"C:\temp\books.csv";
            string strBook = $"{pBook.BookID},{pBook.Title},{pBook.AuthorName},{pBook.cost}";
            using (StreamWriter sw = new StreamWriter(fname, true))
            {
                sw.WriteLine(strBook);
            }
            return View(pBook);





        }
        private Book StringToBook(String[] data, Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.AuthorName = data[2];
            book.cost = float.Parse(data[3]);
            return book;



        }
        public IActionResult ListAllBook()
        {
            string fname = @"c:\temp\books.csv";
            List<Book> list = new List<Book>();
            using (StreamReader sr = new StreamReader(fname))
            {
                string strBook = $"{sr.ReadLine()}";
                string[] data = strBook.Split(',');
                Book book = StringToBook(data, new Book());
                list.Add(book);
                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(",");
                    book = StringToBook(data, new Book());
                    list.Add(book);



                }
            }
            return View(list);
            //Create Author Model - Author ID,  Author Name, Author Date of Birth, No of Books Published,Royalty company.



            // Create Author Controller - CreateAuthor, ListAuthors, ModifyAuthor,FindAuthor,DeleteAuthor



            // Create Views w.r.t to the controller



        }
        public IActionResult AddAuthor()
        {
            Author author = new Author();
            return View(author);
        }
        public IActionResult SaveNewAuthor(Author pAuthor)
        {
            String fName = @"c:\temp\author.csv";
            string strAuthor = $"{pAuthor.Id},{pAuthor.AuthorName},{pAuthor.DateOfBirth},{pAuthor.BooksPublished},{pAuthor.Royalty}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor + Environment.NewLine);
            }
            return View(pAuthor);
            
        }
        private Author StringToAuthor(String[] data, Author author)
        {
            author.Id = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.DateOfBirth = DateTime.Parse(data[2]);
            author.BooksPublished = int.Parse(data[3]);
            author.Royalty = int.Parse(data[4]);
            return author;
        }
        public IActionResult ListAllAuthor()
        {
            string fname = @"c:\temp\author.csv";
            List<Author> list = new List<Author>();
            using (StreamReader sr = new StreamReader(fname))
            {
                string strAuthor = $"{sr.ReadLine()}";
                string[] data = strAuthor.Split(',');
                Author author = StringToAuthor(data,new Author());
                list.Add(author);
                while (!sr.EndOfStream)
                {
                    strAuthor = $"{sr.ReadLine()}";
                    data = strAuthor.Split(",");
                    author = StringToAuthor(data ,new Author());
                    list.Add(author);
                }
            }
            return View(list);
        }
        }
}