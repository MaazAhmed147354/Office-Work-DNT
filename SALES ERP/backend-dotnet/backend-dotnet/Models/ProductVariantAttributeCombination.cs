﻿using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ProductVariantAttributeCombination
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string? AttributesXml { get; set; }

    public int StockQuantity { get; set; }

    public bool AllowOutOfStockOrders { get; set; }

    public string? Sku { get; set; }

    public string? ManufacturerPartNumber { get; set; }

    public string? Gtin { get; set; }

    public decimal? OverriddenPrice { get; set; }
}
