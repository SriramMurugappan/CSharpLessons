namespace ProjectOneMVC.Models
{
    public class Author
    {
        public int Id { set; get; }
        public string AuthorName { set; get; } 
        public DateTime DateOfBirth { set; get; }
        public int BooksPublished { set; get; }
        public int Royalty { set; get; } 
        
    }
}
