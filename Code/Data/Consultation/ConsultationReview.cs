using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Data.Consultation;
    internal class ConsultationReview
    {
        public int Id { get; set; }
    public int ConsultationSlotId { get; set; }
    public int StudentId { get; set; }
    public CourseStudent CourseStudent { get; set; }
    public int LecturerId { get; set; }
    public CourseLecturer CourseLecturer { get; set; }
    public string ReviewText { get; set; } = "";


}
