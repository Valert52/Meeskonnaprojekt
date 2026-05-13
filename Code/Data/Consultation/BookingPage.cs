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
    public int SlotId { get; set; }
    public string StudentId { get; set; } = string.Empty;
    public DateTime BookingDate { get; set; }
    public string Note { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}