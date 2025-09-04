using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwBranchInventoryRequest
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? ProductId { get; set; }

    public int? AvailableQty { get; set; }

    public int? RequestQty { get; set; }

    public int? IssueQty { get; set; }

    public int? RevertQty { get; set; }

    public DateOnly? RequestDate { get; set; }

    public DateOnly? IssueDate { get; set; }

    public DateOnly? RevertDate { get; set; }

    public string? Comments { get; set; }

    public int? Status { get; set; }
}
