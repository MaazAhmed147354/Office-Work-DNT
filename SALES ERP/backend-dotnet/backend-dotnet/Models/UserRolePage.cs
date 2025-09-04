using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class UserRolePage
{
    public long UserRolePageId { get; set; }

    public long? UserRoleId { get; set; }

    public long? PageId { get; set; }

    public bool? IsAdmin { get; set; }

    public bool? IsActive { get; set; }
}
