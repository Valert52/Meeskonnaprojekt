using Abc.Data.Common;

namespace Abc.Data.Consultation;

public sealed class UserRole : BaseEntity
{
    public string UserId { get; set; } = string.Empty;
    public string RoleId { get; set; } = string.Empty;
}