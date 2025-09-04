using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwMissingItem
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public string? Date { get; set; }

    public string? Comments { get; set; }

    public string ProductName { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string? ShortName { get; set; }

    public string? BranchName { get; set; }
}
