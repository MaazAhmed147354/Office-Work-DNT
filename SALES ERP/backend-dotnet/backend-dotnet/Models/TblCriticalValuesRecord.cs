using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblCriticalValuesRecord
{
    public long Id { get; set; }

    public int? BranchId { get; set; }

    public int? ProductId { get; set; }

    public DateTime? CriticalDate { get; set; }
}
