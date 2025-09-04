using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class AclRecord
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public string EntityName { get; set; } = null!;

    public int CustomerRoleId { get; set; }
}
