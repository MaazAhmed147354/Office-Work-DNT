using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwProductSaleDetail
{
    public string? BranchName { get; set; }

    public string? BranchNameShort { get; set; }

    public int CustomerId { get; set; }

    public int OrderId { get; set; }

    public string InvoiceType { get; set; } = null!;

    public int ManufacturerId { get; set; }

    public int CategoryId { get; set; }

    public string Manufacturer { get; set; } = null!;

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public DateOnly? AcceptedDate { get; set; }

    public decimal CostingPrice { get; set; }

    public decimal? OrignalPrice { get; set; }

    public decimal? Price { get; set; }

    public decimal? Profit { get; set; }

    public int Quantity { get; set; }

    public int CompanyId { get; set; }

    public int? BranchId { get; set; }
}
