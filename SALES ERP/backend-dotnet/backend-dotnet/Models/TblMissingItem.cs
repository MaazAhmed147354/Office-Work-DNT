using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblMissingItem
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public string? Date { get; set; }

    public string? Comments { get; set; }
}
