using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvcEfApp.Models
{
    public class Doctor
    {
        [Key]
        [Column("DoctorNo")]
        public int Id {get; set;}
        [Required] //not null
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be between 3 and 20 characters")]
        public string Name { get; set;} = string.Empty;
        [Required]
        public string Speciality { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfBirth { get; set;}
        [Required]
        [Column(TypeName = "Numeric(18,2)")]
        public decimal VisitingFees { get; set;}
        [Required]
        [Column(TypeName = "Numeric(18,0)")]
        public decimal PhoneNumber { get; set;}

    }
}
