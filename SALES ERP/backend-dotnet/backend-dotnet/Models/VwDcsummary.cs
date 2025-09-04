using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwDcsummary
{
    public int? ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? ShortName { get; set; }

    public int BranchId { get; set; }

    public string? Branch { get; set; }

    public DateOnly? Date { get; set; }

    public int? Recieved { get; set; }

    public int? Transfered { get; set; }
}
