using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abc.Data.Consultation;
    public class CourseSelector
    {
    public int Id { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int CourseId { get; set; }
    public CoursePage Course { get; set; }
    public int LecturerId { get; set; }
    public Lecturer Lecturer { get; set; }

}