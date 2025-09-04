using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ViewMonthWiseExpense
{
    public DateTime? Date { get; set; }

    public decimal? Amount { get; set; }

    public int? BranchId { get; set; }

    public int? CompanyId { get; set; }

    public string? DailyMonthly { get; set; }

    public int? TypeId { get; set; }
}
