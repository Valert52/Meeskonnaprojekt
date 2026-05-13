using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abc.Data.Consultation;
    public class CourseSelector
    {
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string LecturerId { get; set; } = string.Empty;
    public string StudentId { get; set; } = string.Empty;
}