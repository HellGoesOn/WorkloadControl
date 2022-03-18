using System.ComponentModel.DataAnnotations;

namespace WorkloadControl.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public int IDTeacherSubject { get; set; }
        public DateTime Day { get; set; }
    }
}
