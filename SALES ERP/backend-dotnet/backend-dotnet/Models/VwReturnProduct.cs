using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwReturnProduct
{
    public int? BranchId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public string ProductName { get; set; } = null!;

    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? BranchName { get; set; }

    public string? BranchShortName { get; set; }
}
