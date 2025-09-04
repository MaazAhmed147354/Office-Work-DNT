using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblPurchaseOrderDetail
{
    public int Id { get; set; }

    public int? Poid { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public int? AddedQuantity { get; set; }

    public decimal? Price { get; set; }

    public decimal? CostingPrice { get; set; }

    public decimal? UnitCostDollar { get; set; }

    public decimal? CustomDuties { get; set; }

    public int? SalesTaxIsManual { get; set; }

    public decimal? SalesTax { get; set; }

    public int? AddSalesTaxIsManual { get; set; }

    public decimal? AddSalesTax { get; set; }

    public int? IncomeTaxIsManual { get; set; }

    public decimal? IncomeTax { get; set; }

    public int? UnitCostPkrIsManual { get; set; }

    public decimal? UnitCostPkr { get; set; }

    public decimal? PerUnitCost { get; set; }
}
