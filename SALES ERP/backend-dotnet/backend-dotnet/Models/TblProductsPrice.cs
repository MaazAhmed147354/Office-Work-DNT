using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblProductsPrice
{
    public int PriceId { get; set; }

    public int? BranchId { get; set; }

    public int? ProductId { get; set; }

    public decimal? RetailPrice { get; set; }

    public decimal? MiniPrice { get; set; }

    public int? CriticalValue { get; set; }

    public int? CriticalValueAll { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? IndustryId { get; set; }
}
