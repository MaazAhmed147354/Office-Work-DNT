using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwChartOfAccount
{
    public string? AccountCode { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? ParentAccountCode { get; set; }

    public string? AccountType { get; set; }
}
