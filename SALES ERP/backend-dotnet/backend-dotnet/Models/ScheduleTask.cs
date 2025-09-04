using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ScheduleTask
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Seconds { get; set; }

    public string Type { get; set; } = null!;

    public bool Enabled { get; set; }

    public bool StopOnError { get; set; }

    public DateTime? LastStartUtc { get; set; }

    public DateTime? LastEndUtc { get; set; }

    public DateTime? LastSuccessUtc { get; set; }
}
