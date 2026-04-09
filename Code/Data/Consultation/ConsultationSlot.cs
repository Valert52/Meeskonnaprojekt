using Abc.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Data.Consultation;
public class ConsultationSlot
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Statusid { get; set; } = "";
    public string Platform { get; set; } = "";
    public string MeetingLink { get; set; } = "";

    public int? CourseId { get; set; }
    public Course Course { get; set; }

    public int? LecturerId { get; set; }
    public Lecturer Lecturer { get; set; }

    public int Code
    {
        get => default;
        set
        {
        }
    }
}