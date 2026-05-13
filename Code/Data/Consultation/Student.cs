using Abc.Data.Common;

namespace Abc.Data.Consultation;

public class Student : NamedEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string StudentCode { get; set; } = string.Empty;

}