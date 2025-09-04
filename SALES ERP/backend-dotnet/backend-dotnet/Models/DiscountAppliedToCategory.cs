using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class DiscountAppliedToCategory
{
    public int DiscountId { get; set; }

    public int CategoryId { get; set; }
}
