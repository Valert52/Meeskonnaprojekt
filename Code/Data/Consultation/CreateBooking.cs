using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Data.Consultation;

internal class CreateBooking
{
    public int Id { get; set; }
    public int CourseLecturerId { get; set; }
    public CourseLecturer CourseLecturer { get; set; }
    public int BookingId { get; set; }
    public BookingPage Booking { get; set; }

}