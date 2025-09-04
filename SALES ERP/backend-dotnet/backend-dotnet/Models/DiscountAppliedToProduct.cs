using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class DiscountAppliedToProduct
{
    public int DiscountId { get; set; }

    public int ProductId { get; set; }
}
