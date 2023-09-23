using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvcEfApp.Models
{
    public class Appointment
    {
        [Key]
        [Column("AppointmentNo")]
        public int Id { get; set; }
        [Required]
        public int PatientId { get; set; }
        [Required]
        public int DoctorId { get; set; }
        [Required]
        public DateTime DateOfAppointment { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
