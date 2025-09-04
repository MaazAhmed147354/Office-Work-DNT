using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwInventoryHistory
{
    public long Id { get; set; }

    public DateOnly? Date { get; set; }

    public int? BranchId { get; set; }

    public int? ProductId { get; set; }

    public long? AvailableGoodsOpening { get; set; }

    public long? AvailableGoodsClosing { get; set; }

    public decimal? AvailableGoodsOpeningCosting { get; set; }

    public decimal? AvailableGoodsClosingCosting { get; set; }

    public string? Status { get; set; }

    public DateOnly? GeneratedDate { get; set; }
}
