using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblHoliday
{
    public int Id { get; set; }

    public string? HolidayName { get; set; }

    public string? DateFrom { get; set; }

    public string? DateTo { get; set; }
}
