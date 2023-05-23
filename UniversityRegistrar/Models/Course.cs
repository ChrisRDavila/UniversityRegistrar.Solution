using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Course 
  {
    public int CourseId { get; set; }
    [Required(ErrorMessage = "The course name field can't be empty!")]
    public string CourseName { get; set; }
    [Required(ErrorMessage = "The course number field can't be empty!")]
    public string CourseNumber { get; set; }
    public List<StudentCourse> JoinEntities { get; }
  }
}