using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Data.Consultation;
public class Student : User
{
    public string StudentGroup { get; set; } = "";

    public int? CourseId { get; set; }
    public CoursePage Course { get; set; }
}