using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Data.Consultation;
public class Notification
{
    public int Id { get; set; }
    public string Message { get; set; } = "";
    public DateTime SentAt { get; set; }
    public string Status { get; set; } = "";

    public int? ConsultationSlotId { get; set; }
    public ConsultationSlot ConsultationSlot { get; set; }

    public int? StudentId { get; set; }
    public Student Student { get; set; }

    public int? LecturerId { get; set; }
    public Lecturer Lecturer { get; set; }
}