using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Data.Consultation;

internal class CourseLecturer
{
    public int Id { get; set; }
    public int? LecturerId { get; set; }
    public Lecturer Lecturer { get; set; }
    public int? CourseId { get; set; }
    public CoursePage Course { get; set; }
}
