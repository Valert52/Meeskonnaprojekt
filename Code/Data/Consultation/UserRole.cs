using Abc.Data.Common;

namespace Abc.Data.Consultation;

public sealed class UserRole : BaseEntity
{
    public int Id { get; set; }
    public int RoleId { get; set; }
    public string UserId { get; set; } = string.Empty;
}