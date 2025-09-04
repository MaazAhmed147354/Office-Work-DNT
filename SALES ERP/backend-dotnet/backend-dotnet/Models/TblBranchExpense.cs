using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblBranchExpense
{
    public long Id { get; set; }

    public long ExpenseId { get; set; }

    public long BranchId { get; set; }

    public bool IsActive { get; set; }
}
