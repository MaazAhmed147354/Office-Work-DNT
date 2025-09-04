using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class UserRole
{
    public long UserRoleId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? IsPage { get; set; }

    public bool? IsActive { get; set; }
}
