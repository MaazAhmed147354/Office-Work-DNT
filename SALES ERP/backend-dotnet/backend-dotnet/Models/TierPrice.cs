using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TierPrice
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int StoreId { get; set; }

    public int? CustomerRoleId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }
}
