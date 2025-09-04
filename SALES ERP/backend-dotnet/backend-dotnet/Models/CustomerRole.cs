using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class CustomerRole
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool FreeShipping { get; set; }

    public bool TaxExempt { get; set; }

    public bool Active { get; set; }

    public bool IsSystemRole { get; set; }

    public string? SystemName { get; set; }

    public int PurchasedWithProductId { get; set; }
}
