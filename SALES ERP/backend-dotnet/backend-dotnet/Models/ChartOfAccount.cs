using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ChartOfAccount
{
    public string? AccountCode { get; set; }

    public int? AccountCodeMasterPart { get; set; }

    public int? AccountCodeNumericPart { get; set; }

    public string? ParentAccountCode { get; set; }

    public string? TopParentOfSameType { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? OpeningBalance { get; set; }

    public decimal? ClosingBalance { get; set; }

    public string? DebitorOrCreditor { get; set; }

    public string? AccountType { get; set; }

    public bool? Hidden { get; set; }

    public bool? LeafNode { get; set; }

    public int? DepthLevel { get; set; }

    public bool? EquityRelated { get; set; }

    public long? CompanyCode { get; set; }
}
