using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblAttendanceParam
{
    public int Id { get; set; }

    public string? OnTime { get; set; }

    public string? OffTime { get; set; }

    public string? LateValue { get; set; }

    public string? AllowLeaves { get; set; }
}
