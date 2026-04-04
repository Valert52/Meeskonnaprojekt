using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Data.Consultation;
public class Lecturer : User
{
    public int? CourseId { get; set; }
    public CoursePage Course { get; set; }
}