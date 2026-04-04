using Abc.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Data.Consultation;
public class BookingPage
{
    public int Id { get; set; }
    public DateTime BookingDate { get; set; }
    public string Status { get; set; } = "";
    public string Note { get; set; } = "";

    public int? StudentId { get; set; }
    public Student Student { get; set; }

    public int? SlotId { get; set; }
    public ConsultationSlot ConsultationSlot { get; set; }
}