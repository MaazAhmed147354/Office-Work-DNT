using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwDc
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int? IssuedQty { get; set; }

    public string? ShortNameRecieved { get; set; }

    public string? ShortNameTransfered { get; set; }

    public string? CommentsApp { get; set; }

    public DateOnly? Date { get; set; }

    public string? CommentsReq { get; set; }

    public int BranchIdrecieved { get; set; }

    public int BranchIdtransfered { get; set; }

    public string? BranchRecieved { get; set; }

    public string? BranchTransfered { get; set; }
}
