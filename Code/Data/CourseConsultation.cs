using System;
using Abc.Data.Consultation;

namespace Abc.Data;

public class CourseConsultation
{
    public Guid Id { get; set; }

    public Guid CourseId { get; set; }
    public Course? Course { get; set; }
}