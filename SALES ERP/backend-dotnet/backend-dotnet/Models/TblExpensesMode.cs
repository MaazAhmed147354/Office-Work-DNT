using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblExpensesMode
{
    public int Id { get; set; }

    public string? Types { get; set; }

    public string? Mode { get; set; }

    public int? OrderBy { get; set; }

    public bool? Active { get; set; }

    public int? ParentExpenseId { get; set; }

    public bool? IsNew { get; set; }
}
