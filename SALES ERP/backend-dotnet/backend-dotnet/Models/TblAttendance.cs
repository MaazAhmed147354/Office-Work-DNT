using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblAttendance
{
    public long Id { get; set; }

    public int? EmployeeCode { get; set; }

    public string? Date { get; set; }

    public string? CheckIn { get; set; }

    public string? CheckOut { get; set; }

    public string? Leave { get; set; }
}
