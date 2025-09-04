using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ActivityLogType
{
    public int Id { get; set; }

    public string SystemKeyword { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool Enabled { get; set; }
}
