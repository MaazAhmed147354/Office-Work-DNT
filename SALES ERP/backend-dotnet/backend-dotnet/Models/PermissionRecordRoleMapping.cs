using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class PermissionRecordRoleMapping
{
    public int PermissionRecordId { get; set; }

    public int CustomerRoleId { get; set; }
}
