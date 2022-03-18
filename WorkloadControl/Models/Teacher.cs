using System.ComponentModel.DataAnnotations;

namespace WorkloadControl.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
    }
}
