using Abc.Data.Common;

namespace Abc.Data.Consultation;

public class User : NamedEntity
{
    public string Email { get; set; } = string.Empty;
}