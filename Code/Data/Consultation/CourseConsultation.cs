using System;

namespace Abc.Data.Consultation;

public class CourseConsultation
{
    public Guid Id { get; set; }

    public Guid CourseId { get; set; }
    public Course Course { get; set; }
}