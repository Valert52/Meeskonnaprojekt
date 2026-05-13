using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Data.Consultation;
public class Notification
{
    public int Id { get; set; }
    public int ConsultationSlotId { get; set; }
    public string LecturerId { get; set; } = string.Empty;
    public string StudentId { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public DateTime SentAt { get; set; }
    public string Status { get; set; } = string.Empty;
}