using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblProductsPricing
{
    public int ProductId { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public decimal? MinimumSalePrice { get; set; }

    public decimal? RetailPrice { get; set; }

    public int? UnitsPerCarton { get; set; }

    public decimal? PromotionalPrice { get; set; }

    public decimal? BulkDiscount { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int? BulkQuantity { get; set; }

    public string? Website { get; set; }
}
