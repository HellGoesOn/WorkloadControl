using System.ComponentModel.DataAnnotations;

namespace WorkloadControl.Models
{
    public class TeacherSubject
    {
        [Key]
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public int GroupId { get; set; }
    }
}
