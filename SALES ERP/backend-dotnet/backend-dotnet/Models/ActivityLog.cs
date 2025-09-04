using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ActivityLog
{
    public int Id { get; set; }

    public int ActivityLogTypeId { get; set; }

    public int CustomerId { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime CreatedOnUtc { get; set; }
}
