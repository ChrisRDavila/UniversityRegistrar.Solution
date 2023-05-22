using System;

namespace UniversityRegistrar.Models

{
  public class Student
  {
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public DateTime Enrollment { get; set; }
  }
}