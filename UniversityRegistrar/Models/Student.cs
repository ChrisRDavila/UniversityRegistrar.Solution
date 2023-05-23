using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models

{
  public class Student
  {
    public int StudentId { get; set; }
    [Required(ErrorMessage = "The students name field can't be empty!")]
    public string StudentName { get; set; }
    public DateTime Enrollment { get; set; }
    public List<StudentCourse> JoinEntities { get; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

  }
}