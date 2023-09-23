using System.Drawing;
using System.Text;

namespace ProjectOneMVC.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int,Author> GetAuthorDictionary()
        {
            String fName = @"c:\temp\Author.csv";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFileExits = System.IO.File.Exists(fName);
            if (isFileExits) 
            {
                using (StreamReader sr = new StreamReader(fName))
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(',');
                    
                    Author author = null;
                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.Id, author);

                        while (sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data = strAuthor.Split(",");
                            if (data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.Id, author);
                            }
                        }
                    }
                }
            }
            return list;
        }
        private static Author StringToAuthor(String[] data,Author author)
        {
            author.Id = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.DateOfBirth = DateTime.Parse(data[2]);
            author.BooksPublished = int.Parse(data[3]);
            author.Royalty = Int32.Parse(data[4]);
            return author;
        }
        public static Author FindAuthorById(int id)
        {
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            Author author = null;
            if(list != null)
            {
                author = list.FirstOrDefault(x =>(x.Key == id)).Value;
            }
            return author;

        }
        public static void SaveToFile(Author pAuthor)
        {
            String Fname = @"c:\temp\Author.csv";
            string strAuthor = $"{pAuthor.Id},{pAuthor.AuthorName},{pAuthor.DateOfBirth},{pAuthor.BooksPublished},{pAuthor.Royalty}";
            using(StreamWriter sw = new StreamWriter(Fname,true))
            {
                sw.WriteLine(strAuthor);
            }
        }
        public static void RemoveAuthor(int id) 
        {
            String fName = @"C:\temp\Author.csv";
            Dictionary<int, Author>list = AuthorRepository.GetAuthorDictionary();
            StringBuilder sbAuthors = new StringBuilder(list.Count + 100);
            foreach(Author author in list.Values)
            {
                if (author.Id == id)
                {
                    sbAuthors.Append($"{author.Id},{author.AuthorName},{author.DateOfBirth},{author.BooksPublished},{author.Royalty}{Environment.NewLine}");
                }
            }
            File.WriteAllText(fName, sbAuthors.ToString());     

        }
        public static void SaveAllAuthorToFile(Dictionary<int, Author> pAuthorList)
        {
            string fName = @"c:\temp\author.csv";
            string strAuthor = $"{pAuthorList.Count}Author";
        }
        public static void UpdateAuthorToFile(Author pAuthor)
        {
            String fName = @"c:\temp\Author.csv";
            Dictionary<int,Author>list = AuthorRepository.GetAuthorDictionary();
            string strAuthor = String.Empty;
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (Author author in list.Values)
                {
                    if (author.Id != pAuthor.Id)
                    {
                        strAuthor = $"{author.Id},{author.AuthorName},{author.DateOfBirth},{author.BooksPublished},{author.Royalty}";
                    }
                    else
                        strAuthor = $"{pAuthor.Id},{author.AuthorName},{author.DateOfBirth},{author.BooksPublished},{author.Royalty}";
                    sw.WriteLine(strAuthor);
                }
            }
        }
      
       
    }
}
