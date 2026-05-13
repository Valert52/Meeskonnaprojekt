using Abc.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Data.Consultation;
public class ConsultationSlot
{
    public int Id { get; set; } //row number
    public int CourseId { get; set; }
    public string LecturerId { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string MeetingLink { get; set; } = string.Empty;
    public bool IsBooked { get; set; }
}