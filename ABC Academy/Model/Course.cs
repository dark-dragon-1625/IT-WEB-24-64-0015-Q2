using System.ComponentModel.DataAnnotations;

namespace ABC_Academy.Model
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string LecturerName { get; set; }
    }
}
