using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwReplacedItem
{
    public int? BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? BranchNameShort { get; set; }

    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? Username { get; set; }

    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public string Replaced { get; set; } = null!;

    public string? ReplacedMacAddress { get; set; }

    public string? Replacement { get; set; }

    public DateOnly? ReplacedDate { get; set; }

    public decimal ReplacePrice { get; set; }

    public string ReplacedWith { get; set; } = null!;

    public int? ProductDetailIdReplaced { get; set; }

    public int? ReplacedWithProductId { get; set; }

    public string? ReplacedWithMacAddress { get; set; }

    public string? ReplacedWithReplacement { get; set; }

    public DateOnly? ReplacedWithReplacedDate { get; set; }
}
