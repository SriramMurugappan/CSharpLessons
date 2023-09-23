using System.ComponentModel.DataAnnotations;

namespace ProjectOneMVC.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        [StringLength(40)]
        [MinLength(3, ErrorMessage = "Name must be become 3 to 30 chars")]
        public string Language { get; set; } = string.Empty;
        
        public string Hero { get; set; } = string.Empty;
        
        public string Director { get; set; } = string.Empty;
       
        public string MusicDirector { get; set; } = string.Empty;
        
        public DateTime ReleaseDate { get; set; }

        public int Cost { get; set; }

        public int Collection { get; set; }
        public int Review { get; set; }

    }   
}
