using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABC_Academy.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }

        public Course Course { get; set; }
    }
}
